using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HelloWorld
{
    public class ReadWriteFromFile : HelloWorld
    {
        private string filepath = @"c:\temp\caesar.txt";

        public ReadWriteFromFile()
        {
            if (!File.Exists(filepath))
            {
                //Initilize with Hello World
                File.Create(filepath).Dispose(); 
                
                CreateString("Hello World");
            }
        }

        public override string ReadString()
        {
            ReadFromFile();
            return base.ReadString();
        }

        private void ReadFromFile()
        {
            try
            {
                using (StreamReader reader = File.OpenText(filepath))
                {
                    string fileContent = reader.ReadToEnd();
                    if (fileContent != null)
                    {
                        this._helloWorld = fileContent;
                    }
                }
            }
            catch (Exception ex)
            {
                //log ex;
                this._helloWorld = null;
            }
            
        }

        public override bool CreateString(string NewValue)
        {
            try
            {
                File.WriteAllText(filepath, NewValue);
                return true;
            }
            catch (Exception ex)
            {
                // log ex;
                return false;
            }

        }
    }
}
