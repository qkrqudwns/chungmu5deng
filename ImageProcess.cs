using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenCvSharp;

namespace signDrivenMenu
{
    class ImageProcess
    {
          public String getVividImage(String path)
        {
            IplImage img = Cv.LoadImage(path);
            IplImage imgOutput = new IplImage(img.Width, img.Height, img.Depth, 1);

            /*------ Image Processing -----*/
            Cv.CvtColor(img, imgOutput, ColorConversion.BgrToGray);
            Cv.Threshold(imgOutput, imgOutput, 40, 255, ThresholdType.Binary);
            //Cv.Dilate(imgOutput, imgOutput);
            Cv.Erode(imgOutput, imgOutput);
            // Cv.Erode(imgOutput, imgOutput);
            /*
            while (threshold < 255)
            {
                Cv.Threshold(img, imgOutput, threshold, 255, ThresholdType.Binary);
                Cv.NamedWindow("Test", WindowMode.AutoSize);
                Cv.ShowImage("Test", imgOutput);
                Cv.WaitKey(0);

                threshold += gap;
            }
            */

            /*----- Save Converted Image -----*/
            String[] splitText = path.Split('/');
            String tempFileName = splitText[splitText.Length - 1];
            String finalFileName = "";

            tempFileName = "conv_" + tempFileName;
            splitText[splitText.Length - 1] = tempFileName;

            for (int i = 0; i < splitText.Length; i++)
            {
                finalFileName += splitText[i];
            }
            Cv.SaveImage(finalFileName, imgOutput);

            /*----- Release Resources -----*/
            Cv.ReleaseImage(img);
            Cv.ReleaseImage(imgOutput);

            return finalFileName;
        }
    }
}
