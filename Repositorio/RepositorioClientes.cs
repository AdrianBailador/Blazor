using BlazorCurso.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCurso.Repositorio
{
    public class RepositorioClientes : IClientesRepositorio
    {
        private string CadenaConexion;

        public RepositorioClientes(String cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
        }
        public async Task<bool> GuardarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
