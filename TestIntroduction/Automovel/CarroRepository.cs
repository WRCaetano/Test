﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automovel
{
    public class CarroRepository
    {
        public virtual Carro ConsultarMotor(string nome) {
            return new Carro { Motor = "Honda"};
        }
    }
}
