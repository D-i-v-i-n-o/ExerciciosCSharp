using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaqueBancario.Exception
{
    internal class DomainExeception : ApplicationException
    {
        public DomainExeception(string message): base(message) { }  
    }
}
