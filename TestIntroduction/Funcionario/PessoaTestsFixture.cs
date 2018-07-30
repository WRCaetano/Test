using Bogus;
using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    //install-package bogus
    public class PessoaTestsFixture
    {
        public Pessoa ObterPessoaValida()
        {
            return GerarPessoas(1, true, true).First();
        }

        public Pessoa ObterPessoaInvalida()
        {
            var customerTests = new Faker<Pessoa>("pt_BR")
                .CustomInstantiator(f => new Pessoa(
                    Guid.NewGuid(),
                    f.Name.FirstName(Name.Gender.Male),
                    f.Name.LastName(Name.Gender.Male),
                    f.Date.Past(1, DateTime.Now.AddYears(1)),
                    "",
                    false,
                    DateTime.Now, 
                    false));

            return customerTests;
        }

        public ICollection<Pessoa> ObterMistoPessoas()
        {
            var customers = new List<Pessoa>();

            customers.AddRange(GerarPessoas(50, true, true).ToList());
            customers.AddRange(GerarPessoas(50, false, false).ToList());

            return customers;
        }

        private static IEnumerable<Pessoa> GerarPessoas(int quantidade, bool estaAtivo, bool estaValido)
        {
            var customerTests = new Faker<Pessoa>("pt_BR")
                .CustomInstantiator(f => new Pessoa(
                    Guid.NewGuid(),
                    f.Name.FirstName(Name.Gender.Male),
                    f.Name.LastName(Name.Gender.Male),
                    f.Date.Past(80, DateTime.Now.AddYears(-18)),
                    f.Internet.Email().ToLower(),
                    estaAtivo,
                    DateTime.Now,
                    estaValido));

            return customerTests.Generate(quantidade);
        }

    }
}
