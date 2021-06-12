using System;
using TCU_SodaAmira.DA;

namespace TCU_SodaAmira.BLL
{
    public class RepositorioDelProyecto : IRepositorioDelProyecto
    {
        private ContextoDeBaseDeDatos elContextoDeBaseDeDatos;

        public RepositorioDelProyecto(ContextoDeBaseDeDatos contexto)
        {
            elContextoDeBaseDeDatos = contexto;
        }

    }
}
