using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automovel
{
    public interface ICarroRepository
    {
        Carro ConsultarMotor(string nome);
    }
}
