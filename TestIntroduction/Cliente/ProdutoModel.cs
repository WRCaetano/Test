using System;

namespace Cliente
{
    public class ProdutoModel:Entity
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public ProdutoModel()
        {

        }

        public ProdutoModel(Guid id, string nome, decimal valor)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
        }
    }
}