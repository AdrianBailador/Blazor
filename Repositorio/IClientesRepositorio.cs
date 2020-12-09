using BlazorCurso.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCurso.Repositorio
{
   interface IClientesRepositorio
    {
        Task<bool> GuardarCliente(Cliente cliente);
    }
}
