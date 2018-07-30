using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Funcionario
{
    public class PessoaTests
    {
        public PessoaTestsFixture Fixture { get; set; }
        public PessoaTests()
        {
            Fixture = new PessoaTestsFixture();
        }
        [Fact]
        public void Pessoa_ObterPessoaValida_True() {
            //Cenario
            var pessoa = Fixture.ObterPessoaValida();

            //Ação
            var resultado = pessoa.EhValido;

            //Validação
            Assert.True(resultado);
        }

        [Fact]
        public void Pessoa_ObterPessoaInvalida_False()
        {
            //Cenario
            var pessoa = Fixture.ObterPessoaInvalida();

            //Ação
            var resultado = pessoa.EhValido;

            //Validação
            Assert.False(resultado);
        }

        [Fact]
        public void Pessoa_ObterMistoPessoas_True()
        {
            //Cenario
            var pessoa = Fixture.ObterMistoPessoas();

            //Ação
            var ativo = pessoa.FirstOrDefault(p=>p.Ativo);
            var inativo = pessoa.FirstOrDefault(p=>p.Ativo==false);
            //Validação
            Assert.NotNull(ativo);
            Assert.NotNull(inativo);
        }
    }
}
