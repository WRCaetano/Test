using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cliente
{
    public interface IClienteService : IDisposable
    {
        void Adicionar(ClienteModel obj);
        void Excluir(ClienteModel obj);
    }
}
