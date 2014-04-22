using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PhotoBombXL
{
    class ConverterUtil
    {
        public static void convertFiles(List<ImageFilePathUtil> filesToBeConverted, Profile.fileTypes whichTypeOfFileToConvertTo, string destinationPath)
        {
            foreach (ImageFilePathUtil file in filesToBeConverted)
            {
                // check to make sure we are using a valid file
                if (isFilePathValid(file.fullPath))
                {
                    Image image = Image.FromFile(file.fullPath);

                    // choose which kind of file to convert the image to
                    if (whichTypeOfFileToConvertTo == Profile.fileTypes.GIF)
                    {
                        image.Save(destinationPath + "\\" + file.nameWithoutExtension + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
                    }
                    else if (whichTypeOfFileToConvertTo == Profile.fileTypes.JPG)
                    {
                        image.Save(destinationPath + "\\" + file.nameWithoutExtension + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else if (whichTypeOfFileToConvertTo == Profile.fileTypes.PNG)
                    {
                        image.Save(destinationPath + "\\" + file.nameWithoutExtension + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    }
                    else if (whichTypeOfFileToConvertTo == Profile.fileTypes.TIFF)
                    {
                        image.Save(destinationPath + "\\" + file.nameWithoutExtension + ".tiff", System.Drawing.Imaging.ImageFormat.Tiff);
                    }
                    else if (whichTypeOfFileToConvertTo == Profile.fileTypes.BMP)
                    {
                        image.Save(destinationPath + "\\" + file.nameWithoutExtension + ".tiff", System.Drawing.Imaging.ImageFormat.Bmp);
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
