using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cliente
{
    public interface IRepository<TEntity>:IDisposable where TEntity : Entity
    {
        void Adicionar(TEntity obj);
        TEntity ObterPorId(Guid id);
    }
}
