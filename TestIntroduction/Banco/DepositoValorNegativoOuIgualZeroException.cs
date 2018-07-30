using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class DepositoValorNegativoOuIgualZeroException : Exception
    {
        public DepositoValorNegativoOuIgualZeroException(string message)
            : base(message)
        {

        }
    }
}
