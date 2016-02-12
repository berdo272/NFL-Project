using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SportsManagement
{
    class FileRead
    {
        public string readFile(string filePath)
        {
            string output;

            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            output = sr.ReadToEnd();

            sr.Close();
            fs.Close();
            return output;            
        }
    }
}
