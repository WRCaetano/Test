using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; private set; }
        public string SobreNome { get; private set; }
        public DateTime Aniversario { get; private set; }
        public DateTime DataRegistro { get; private set; }
        public string Email { get; private set; }
        public bool Ativo { get; private set; }

        public bool EhValido { get; set; }

        protected Pessoa() { }

        public Pessoa(Guid id, string nome, string sobreNome, DateTime aniversario, string email, bool ativo, DateTime dataRegistro, bool ehValido)
        {
            Id = id;
            Nome = nome;
            SobreNome = sobreNome;
            Aniversario = aniversario;
            Email = email;
            Ativo = ativo;
            DataRegistro = dataRegistro;
            EhValido = ehValido;
        }

        public string NomeCompleto()
        {
            return Nome + " " + SobreNome;
        }

        public bool EhEspecial()
        {
            return DataRegistro < DateTime.Now.AddYears(-3) && Ativo;
        }

        public void MarcarInativo()
        {
            Ativo = false;
        }
    }
}
