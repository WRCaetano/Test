using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        private decimal _saldo { get; set; }
        public string Numero { get; set; }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new DepositoValorNegativoOuIgualZeroException("O valor do depósito não pode ser menor ou igual a zero.");

            _saldo += valor;
        }

        public decimal ConsultarSaldo()
        {
            return _saldo;
        }

        public void Sacar(decimal valor)
        {
            if (valor > ConsultarSaldo())
                throw new SaqueMaiorQueFundoException("Saque não pode exceder o saldo.");

            _saldo -= valor;
        }
    }
}
