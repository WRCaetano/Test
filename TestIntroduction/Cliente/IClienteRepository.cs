using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cliente
{
    public interface IClienteRepository : IRepository<ClienteModel>
    {
        ClienteModel ObterPorEmail(string email);
    }
}
