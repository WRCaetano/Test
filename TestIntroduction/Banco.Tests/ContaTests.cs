using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Banco.Tests
{
    // Classe que simula uma conta corrente
    // Depositar Dinheiro
    // Consultar saldo
    // Sacar dinheiro
    // Nao permitir saque superior aos fundos
    // Nao permitir deposito em valor negativo
    // Nao permitir saque em valor negativo
    // Saque de CH especial

    public class ContaTests
    {
        // AAA
        [Fact]
        public void Conta_DepositarDinheiro_ValidarSaldo()
        {
            // Arrange
            var conta = new Conta();
            var saldoInicial = 500M;
            conta.Depositar(saldoInicial);
            var deposito = 200M;

            // Act
            conta.Depositar(deposito);

            // Assert          
            Assert.True(conta.ConsultarSaldo() == saldoInicial + deposito);
        }

        [Fact]
        public void Conta_ConsultarSaldo_ValidarSaldo()
        {
            // Arrange
            var conta = new Conta();
            var deposito = 500;
            conta.Depositar(deposito);

            // Act
            var saldo = conta.ConsultarSaldo();

            // Assert          
            Assert.True(saldo == deposito);
        }

        [Fact]
        public void Conta_SacarDinheiro_RetornarSaldoDebitado()
        {
            // Arrange
            var conta = new Conta();
            var saque = 50;
            conta.Depositar(50.40M);

            // Act
            conta.Sacar(saque);

            // Assert          
            Assert.True(conta.ConsultarSaldo() == 0.4M);
        }

        [Fact]
        public void Conta_SacarDinheiroMaiorQueSaldo_NaoPermitirSaldoNegativo()
        {
            // Arrange
            var conta = new Conta();
            conta.Depositar(50.5M);
            var saque = 60;

            // Assert          
            var exReturn = Assert.Throws<SaqueMaiorQueFundoException>(() => conta.Sacar(saque));
            Assert.True(exReturn.Message == "Saque não pode exceder o saldo.");
        }

        [Fact]
        public void Conta_DepositarDinheiro_NaoPermitirDepositoNegativoOuIgualZero()
        {
            // Arrange
            var conta = new Conta();
            var deposito = -50;

            // Assert          
            var exReturn = Assert.Throws<DepositoValorNegativoOuIgualZeroException>(() => conta.Depositar(deposito));
            Assert.True(exReturn.Message == "O valor do depósito não pode ser menor ou igual a zero.");
        }
    }
}
