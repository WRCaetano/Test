﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cliente
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
    }
}
