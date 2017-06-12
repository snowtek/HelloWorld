using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class HelloWorld : IHelloWorld
    {
        /// <summary>
        /// property that holds the string and defaulted with "Hello World"
        /// </summary>
        protected string _helloWorld = "Hello World";

        /// <summary>
        /// Contructor
        /// </summary>
        public HelloWorld()
        {
            _helloWorld = "Hello World";
        }

        /// <summary>
        /// Create Operation
        /// </summary>
        /// <param name="NewValue"></param>
        /// <returns></returns>
        public virtual bool CreateString(string NewValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete Operation
        /// </summary>
        /// <param name="NewValue"></param>
        /// <returns></returns>
        public virtual bool DeleteString(string NewValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Read Operation
        /// </summary>
        /// <returns></returns>
        public virtual string ReadString()
        {
            return _helloWorld;
        }

        /// <summary>
        /// Update Operation
        /// </summary>
        /// <param name="NewValue"></param>
        /// <returns></returns>
        public virtual bool UpdateString(string NewValue)
        {
            throw new NotImplementedException();
        }
    }
}
