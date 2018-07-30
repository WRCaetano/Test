using Moq;
using Xunit;

namespace Cliente
{
    public class ClienteTests
    {
        //install-package xunit
        //install-package xunit.runner.visualstudio
        //install-package automoq
        //install-package moq

        public ClienteTestsFixture Fixture { get; set; }
        public ClienteTests()
        {
            Fixture =new ClienteTestsFixture();
        }
        [Fact]
        public void ClienteService_Adicionar_AdicionadoComSucesso() {
            // Arrange = cenario
            var clienteService = Fixture.ObterClienteService();
            var cliente = Fixture.ObterCliente();

            // Act = ação
            clienteService.Adicionar(cliente);

            // Assert = validação
            Fixture.ClienteRepositoryMock.Verify(r => r.Adicionar(cliente), Times.Once);
        }
    }
}
