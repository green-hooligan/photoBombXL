﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoBombXL
{
    class Profile
    {
        public enum fileTypes
        {
            JPG,
            RAW,
            GIF,
            PNG,
            BMP,
            TIFF
        };

        public enum exifMaintained
        {
            Yes,
            No
        }

        public enum fileSizeIndicator
        {
            mb,
            kb
        }

        public string name { get; set; }
        public int heightInPixels { get; set; }
        public int widthInPixels { get; set; }
        public fileTypes fileType { get; set; }
        public int fileSize { get; set; }
        public fileSizeIndicator indicator { get; set; } 
        public int aspectHeight { get; set; }
        public int aspectWidth { get; set; }
        public bool isExifMaintained { get; set; }

        public Profile(String name, int heightInPixels, int widthInPixels, fileTypes fileType, int fileSize, fileSizeIndicator fsi,int aspectHeight, int aspectWidth, bool isExifMaintained)
        {
            this.name = name;
            this.heightInPixels = heightInPixels;
            this.widthInPixels = widthInPixels;
            this.fileType = fileType;
            this.fileSize = fileSize;
            this.indicator = fsi;
            this.aspectHeight = aspectHeight;
            this.aspectWidth = aspectWidth;
            this.isExifMaintained = isExifMaintained;
        }
    }
}
