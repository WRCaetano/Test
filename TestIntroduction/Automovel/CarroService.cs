using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automovel
{
    public class CarroService
    {
        private readonly ICarroRepository _carroRepository;

        public CarroService(ICarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }

        public Carro ConsultarMotor(string nome) {
            return _carroRepository.ConsultarMotor(nome);
        }
    }
}
