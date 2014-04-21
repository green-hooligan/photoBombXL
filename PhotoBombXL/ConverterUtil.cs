using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PhotoBombXL
{
    class ConverterUtil
    {
        public enum fileTypes
        {
            PNG,
            JPG,
            GIF,
            RAW,
            BMP,
            TIFF
        }

        public static void convertFiles(List<string> filesToBeConverted, ConverterUtil.fileTypes whichTypeOfFileToConvertTo, string destinationPath)
        {
            foreach (string file in filesToBeConverted)
            {
                // check to make sure we are using a valid file
                if (isFilePathValid(file))
                {
                    System.Drawing.Image image = System.Drawing.Image.FromFile(file);

                    // choose which kind of file to convert the image to
                    if (whichTypeOfFileToConvertTo == ConverterUtil.fileTypes.GIF)
                    {
                        image.Save(destinationPath, System.Drawing.Imaging.ImageFormat.Gif);
                    }
                    else if (whichTypeOfFileToConvertTo == ConverterUtil.fileTypes.JPG)
                    {
                        image.Save(destinationPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else if (whichTypeOfFileToConvertTo == ConverterUtil.fileTypes.PNG)
                    {
                        image.Save(destinationPath, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    else if (whichTypeOfFileToConvertTo == ConverterUtil.fileTypes.GIF)
                    {
                        image.Save(destinationPath, System.Drawing.Imaging.ImageFormat.Gif);
                    }
                    else if (whichTypeOfFileToConvertTo == ConverterUtil.fileTypes.TIFF)
                    {
                        image.Save(destinationPath, System.Drawing.Imaging.ImageFormat.Tiff);
                    }
                }
            }
        }

        // this is to do some last minute checking to make sure we are opporating on a valid file
        public static bool isFilePathValid(string filepath)
        {
            if (File.Exists(filepath) &&
                    
                 (string.Equals(Path.GetExtension(filepath), ".jpg", StringComparison.CurrentCultureIgnoreCase) ||
                 string.Equals(Path.GetExtension(filepath), ".jpeg", StringComparison.CurrentCultureIgnoreCase) ||
                 string.Equals(Path.GetExtension(filepath), ".raw", StringComparison.CurrentCultureIgnoreCase)  ||
                 string.Equals(Path.GetExtension(filepath), ".gif", StringComparison.CurrentCultureIgnoreCase)  ||
                 string.Equals(Path.GetExtension(filepath), ".png", StringComparison.CurrentCultureIgnoreCase)  ||
                 string.Equals(Path.GetExtension(filepath), ".bmp", StringComparison.CurrentCultureIgnoreCase)  ||
                 string.Equals(Path.GetExtension(filepath), ".tiff", StringComparison.CurrentCultureIgnoreCase)  )
               )
            {
                return true;
            }
            return false;
        }
    }
}
