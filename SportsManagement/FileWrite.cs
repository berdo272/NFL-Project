using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManagement
{
    class FileWrite
    {
        public FileWrite()
        {

        }

        public void WriteToFile(string path, string textToBeWritten)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);

            sr.Write(textToBeWritten);

            sr.Close();
            fs.Close();
            

        }
    }
}
