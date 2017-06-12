using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HelloWorld
{
    class ReadWriteFromFile : HelloWorld
    {
        string filepath = @"c:\file.txt";

        public ReadWriteFromFile()
        {

        }
        public override string ReadString()
        {
            try
            {
                using (StreamReader reader = File.OpenText(filepath))
                {
                    string fileContent = reader.ReadToEnd();
                    if (fileContent != null && fileContent != "")
                    {
                        return fileContent;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
