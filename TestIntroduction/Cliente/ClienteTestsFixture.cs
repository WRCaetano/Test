using AutoMoq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
   public  class ClienteTestsFixture : IDisposable
    {

        public Mock<IClienteRepository> ClienteRepositoryMock { get; set; }
        public Mock<IProdutoRepository> ProdutoRepositoryMock { get; set; }
        public Mock<IClienteService> ClienteService { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public ClienteService ObterClienteService()
        {

            var mocker = new AutoMoqer();
            mocker.Create<ClienteService>();            

            ClienteRepositoryMock = mocker.GetMock<IClienteRepository>();
            ClienteService = mocker.GetMock<IClienteService>();
            ProdutoRepositoryMock = mocker.GetMock<IProdutoRepository>();

            var clienteService = mocker.Resolve<ClienteService>();
            return clienteService;
        }

        public ClienteModel ObterCliente() {
            return new ClienteModel(Guid.NewGuid(), "Charles", "Fernandes", DateTime.Now, "email@email.com");
        }
    }
}
