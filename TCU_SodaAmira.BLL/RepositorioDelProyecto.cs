using System;
using System.Collections.Generic;
using System.Linq;
using TCU_SodaAmira.DA;
using TCU_SodaAmira.Models;

namespace TCU_SodaAmira.BLL
{
    public class RepositorioDelProyecto : IRepositorioDelProyecto
    {
        private ContextoDeBaseDeDatos elContextoDeBaseDeDatos;

        public RepositorioDelProyecto(ContextoDeBaseDeDatos contexto)
        {
            elContextoDeBaseDeDatos = contexto;
        }

        public List<Inventario> ObtenerTodoElInventario()
        {
            List<Inventario> Lalista;
            Lalista = elContextoDeBaseDeDatos.Inventario.ToList();
            return Lalista;
        }
    }
}
