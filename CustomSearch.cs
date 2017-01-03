using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis;
using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Translate.v2;
using Google.Apis.Translate.v2.Data;
using Google.Apis.Services;
using System.Net;
using System.Web;
using HtmlAgilityPack;
using TranslationsResource = Google.Apis.Translate.v2.Data.TranslationsResource;
namespace signDrivenMenu
{
    public class CustomSearch : CustomApi
    {
        public Search searchFromKeyword(String keyword)
        {
            Search search = null;
            try
            {
                CustomsearchService customSearchService = new CustomsearchService(new Google.Apis.Services.BaseClientService.Initializer() { ApiKey = mKey });
                Google.Apis.Customsearch.v1.CseResource.ListRequest listRequest = customSearchService.Cse.List(keyword);
                listRequest.Cx = mEngineId;
                search = listRequest.Execute();
            }
            catch (Google.GoogleApiException e)
            {
                
            }
            return search;
        }
    }
}
