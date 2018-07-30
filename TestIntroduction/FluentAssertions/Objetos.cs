using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAssertionsTeste
{
    public class Objetos
    {
        public string RetornarString() {
            return "abcde";
        }
        public bool RetornarBoleano() {
            return true;
        }

        public Tuple<string, int> RetornarTuple() {

            return new Tuple<string, int>("Teste",1);

        }
    }
}
