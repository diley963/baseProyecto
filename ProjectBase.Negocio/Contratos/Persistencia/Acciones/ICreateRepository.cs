﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBase.Negocio.Contratos.Persistencia.Acciones
{
    public interface ICreateRepository<T> where T : class
    {
        void Create(T t);
    }
}
