using FluentAssertions;
using System;
using Xunit;

namespace Calculo.Tests
{
    //install-package xunit
    //install-package xunit.runner.visualstudio
    //install-package fluentassertions
    [CollectionDefinition(name: nameof(CalculadoraTests))]
    public class CalculadoraTests
    {
        [Fact(DisplayName = "Calculo Adicionar")]
        [Trait("Calculo", "Calculo Adicionar Tests")]
        public void Calculo_Adicionar_True()
        {
            //Fluent Assertions
            Calculadora.Adicao(2, 2).Should().Be(4);
            //XUnit
            Assert.True(Calculadora.Adicao(2, 2) == 4);
        }

        [Fact]
        public void Calculo_Subtrair_True()
        {
            Assert.True(Calculadora.Subtracao(6, 2) == 4);
        }

        [Fact]
        public void Calculo_Multiplicar_True()
        {
            Assert.True(Calculadora.Multiplicacao(6, 2) == 12);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(8, 2, 4)]
        [InlineData(6, 3, 2)]
        [InlineData(10, 5, 2)]
        [InlineData(100, 2, 50)]

        public void Calculo_Dividir_True(int v1, int v2, int v3)
        {
            Assert.True(Calculadora.Divisao(v1, v2) == v3);
        }

        [Theory]
        [InlineData(2, 0, 50)]
        public void Calculo_Dividir_Por_Zero_Exeption(int v1, int v2, int v3)
        {
            Assert.Throws<DivideByZeroException>(() => Calculadora.Divisao(v1, v2) == v3);
            Action ex = () => Calculadora.Divisao(v1, v2);
            ex.Should().Throw<DivideByZeroException>();

        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(9)]
        public void Calculo_EhImpar_True(int v1)
        {
            Assert.True(Calculadora.EhImpar(v1));
        }
    }
}
