using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODI;
using System.Drawing;

namespace signDrivenMenu
{
    class CustomOCR
    {
        public String Convert2OCR(String file)
        {
            String extractedText = String.Empty;
                        
            MODI.Document md = new MODI.Document();
            md.Create(file);            
            try
            {
                md.OCR(MODI.MiLANGUAGES.miLANG_ENGLISH, false, true);

                MODI.Image image = (MODI.Image)md.Images[0];
                MODI.Layout layout = image.Layout;

                for (int i = 0; i < layout.Words.Count; i++)
                {
                    MODI.Word word = (MODI.Word)layout.Words[i];
                    if (extractedText.Length > 0)
                    {
                        extractedText += " ";
                    }
                    extractedText += word.Text;

                }
            }
            catch (Exception e)
            {
                extractedText = e.Message + " / " + e.StackTrace.ToString();
                md.Close(false);
            }
            finally
            {
                md.Close(false);
            }

            return extractedText;
        }
    }
}

