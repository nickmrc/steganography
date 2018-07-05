using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace StegProject
{
    class FilePic
    {
        Bitmap picture;
        string filePath;

        public FilePic(Bitmap picture, string filePath)
        {
            this.picture = picture;
            this.filePath = filePath;
        }

        public int GetPicCapasity()
        {
            return picture.Height*picture.Width;
        }

        public Bitmap GetPic()
        {
            return this.picture;
        }

        private string GetFileName()
        {
            return Path.GetFileName(this.filePath);
        }

        public string FileName
        {
            
            get { return this.GetFileName(); }
        }

        public int Capasity
        {
      
            get { return this.GetPicCapasity(); }
        }
    }
}
