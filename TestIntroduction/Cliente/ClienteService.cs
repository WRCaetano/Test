using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cliente
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IProdutoRepository _produtoRepository;

        public ClienteService(IClienteRepository clienteRepository, IProdutoRepository produtoRepository)
        {
            _clienteRepository = clienteRepository;
            _produtoRepository = produtoRepository;
        }

        public void Adicionar(ClienteModel obj)
        {
            _produtoRepository.ObterPorId(Guid.NewGuid());
            if (_clienteRepository.ObterPorId(Guid.NewGuid()) == null)
                _clienteRepository.Adicionar(obj);
        }

        public void Excluir(ClienteModel obj)
        {
            _clienteRepository.ObterPorEmail(obj.Email);
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }
    }
}
