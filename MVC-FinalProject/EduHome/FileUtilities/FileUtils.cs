using EduHome.Constants;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace EduHome.FileUtilities
{
    public class FileUtils
    {
        public static string Create(string FolderPath, IFormFile file)
        {
            var fileName = Guid.NewGuid() + file.FileName;
            var fullPath = Path.Combine(FolderPath, fileName);
            FileStream stream = new FileStream(fullPath, FileMode.Create);
            file.CopyTo(stream);
            stream.Close();
            return fileName;
        }

        public static void Delete(string fullPath)
        {
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }

        public static void Delete2(string imageName)
        {
            string fullPath = Path.Combine(FileConstants.ImagePath, imageName);
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }
    }
}
