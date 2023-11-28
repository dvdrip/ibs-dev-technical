using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ibs_dev_technical
{
    public class Revisions
    {
        public FileDetails? CheckForRevisions(string fileName)
        {
            string currentFileName = "";

            //check if fileName is null
            if (string.IsNullOrEmpty(fileName))
            {
                return null;
            }

            //check revision and return file details
            return null;
        }

        public string GetFileHash(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    byte[] hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLower();
                }
            }
        }
    }
}
