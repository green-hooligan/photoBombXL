using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoBombXL
{
    class Profile
    {
        public string name { get; set; }
        public int heightInPixels { get; set; }
        public int widthInPixels { get; set; }
        public int fileType { get; set; }
        public int fileSize { get; set; }
        public int aspectHeight { get; set; }
        public int aspectWidth { get; set; }
        public bool isExifMaintained { get; set; }
    }
}
