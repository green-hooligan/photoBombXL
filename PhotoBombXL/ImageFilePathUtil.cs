using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PhotoBombXL
{
    class ImageFilePathUtil
    {
        public string fullPath { get; set; }
        public string fileName { get; set; }
        public string extension { get; set; }

        public ImageFilePathUtil(string fullPath)
        {
            this.fullPath = fullPath;
            this.fileName = Path.GetFileName(fullPath);
            this.extension = Path.GetExtension(fullPath).ToLower();
        }
    }
}
