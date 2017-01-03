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
    class CustomTranslation : CustomApi
    {
        private String mOutputText = null;
        private String mTargetLanguage = null;

        private async Task Run()
        {
            // Create the translation service.
            var service = new TranslateService(new BaseClientService.Initializer()
            {
                ApiKey = mKey, // your API key, that you get from Google Developer Console
                ApplicationName = mEngineId // your application name, that you get form Google Developer Console
            });

            string[] srcText = new[] { mOutputText };
            var response = await service.Translations.List(srcText, mTargetLanguage).ExecuteAsync();
            String translated_text = response.Translations[0].TranslatedText;
        }

        [STAThread]
        public String translate(String inputText)
        {
            if (inputText != null)
            {
                try
                {
                    new CustomTranslation().Run().Wait();
                }
                catch (AggregateException ex)
                {
                    foreach (var e in ex.InnerExceptions)
                    {
                        Console.WriteLine("ERROR: " + e.Message);
                    }
                }
            }
            return mOutputText;
        }
    }
}
