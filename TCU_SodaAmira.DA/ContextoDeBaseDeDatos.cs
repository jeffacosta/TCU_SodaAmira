using Microsoft.EntityFrameworkCore;
using System;

namespace TCU_SodaAmira.DA
{
    public class ContextoDeBaseDeDatos : DbContext
    {
        public ContextoDeBaseDeDatos() { }
        public ContextoDeBaseDeDatos(DbContextOptions<ContextoDeBaseDeDatos> opciones) : base(opciones)
        { }
    }
}
