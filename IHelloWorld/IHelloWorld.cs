using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    /// <summary>
    /// Hello World Interface
    /// </summary>
    public interface IHelloWorld
    {
        bool CreateString(string NewValue);
        string ReadString();
        bool UpdateString(string NewValue);
        bool DeleteString(string NewValue);
    }
}
