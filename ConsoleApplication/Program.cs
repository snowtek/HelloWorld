using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int? source = Int32.Parse(ConfigurationSettings.AppSettings["source"]);

            switch (source)
            {
                case 0:
                    DefaultResponse();
                    break;
                case 1:
                    ClassResponse();
                    break;
                case 2:
                    FileResponse();
                    break;
                default:
                    DefaultResponse();
                    break;
            }
            
         
           
        }

        private static void ClassResponse()
        {
            IHelloWorld API = new HelloWorld();
            Console.WriteLine(string.Format("{0}!", API.ReadString()));
            Console.ReadKey();
        }

        private static void FileResponse()
        {
            IHelloWorld API = new ReadWriteFromFile();
            Console.WriteLine(string.Format("{0}!", API.ReadString()));
            Console.ReadKey();
        }

        private static void DefaultResponse()
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}