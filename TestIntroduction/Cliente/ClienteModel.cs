using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cliente
{
    public class ClienteModel:Entity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Aniversario { get; set; }
        public string Email { get; set; }

        public ClienteModel()
        {

        }

        public ClienteModel(Guid id, string nome, string sobrenome, DateTime aniversario, string email)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Aniversario = aniversario;
            Email = email;
        }

        public string NomeCompleto() {
            return Nome + " " + Sobrenome;
        }
    }
}
