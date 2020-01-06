using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoUploader
{
    class FileManager
    {
        private string[] files;
        private Random random;

        public FileManager()
        {
            files = Directory.GetFiles("Images");
            random = new Random();
        }

        public string[] Files()
        {
            return files;
        }

        public string GetRandomFile()
        {
            return (files.Length == 0) ? "No one files in Images" : Path.GetFullPath(files[random.Next(0, files.Length - 1)]);
        }
    }
}
