using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class SaqueMaiorQueFundoException : Exception
    {
        public SaqueMaiorQueFundoException(string message)
            : base(message)
        {

        }
    }
}
