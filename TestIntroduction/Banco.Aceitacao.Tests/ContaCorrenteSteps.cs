using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Banco.Aceitacao.Tests
{
    [Binding]
    public class ContaCorrenteSteps
    {
        public Conta Conta = new Conta();

        [Given(@"que uma conta esteja ativa")]
        public void DadoQueUmaContaEstejaAtiva()
        {
            Assert.NotNull(Conta);
        }

        [Given(@"que esteja sem saldo")]
        public void DadoQueEstejaSemSaldo()
        {
            Assert.True(Conta.ConsultarSaldo() == 0);
        }

        [When(@"For realizado o deposito de um valor")]
        public void QuandoForRealizadoODepositoDeUmValor(Table table)
        {
            Conta.Depositar(Convert.ToDecimal(table.Rows[0][0]));
        }

        [Then(@"O saldo disponivel deve o mesmo que o depositado")]
        public void EntaoOSaldoDisponivelDeveOMesmoQueODepositado(Table table)
        {
            Assert.True(Conta.ConsultarSaldo() == Convert.ToDecimal(table.Rows[0][0]));
        }
    }
}
