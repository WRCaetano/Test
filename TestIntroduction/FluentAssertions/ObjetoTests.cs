using Xunit;
using FluentAssertions;

namespace FluentAssertionsTeste
{
    //install-package xunit
    //install-package xunit.runner.visualstudio
    //install-package fluentassertions
    public class ObjetoTests
    {
        [Fact]
        public void ObJeto_RetornarString_DeveConterCincoCaracteres() {
            var retornarString = new Objetos();
            
            retornarString.RetornarString().Should().HaveLength(5);
            retornarString.RetornarString().Should().StartWith("abc").And.EndWith("de");
        }

        [Fact]
        public void Objeto_RetornarBoleano_DeveSerVerdadeiro() {
            var retornaBool = new Objetos();
            retornaBool.RetornarBoleano().Should().BeTrue();
        }

        [Fact]
        public void Objeto_RetornarTuple_StringDeveSerTesteIntDeveSerUm() {
            var tuple = new Objetos().RetornarTuple();
            tuple.Item1.Should().Be("Teste").And.BeOfType<string>();
            tuple.Item2.Should().BeGreaterOrEqualTo(0);
            tuple.Item2.Should().Be(1);
        }
    }
}
