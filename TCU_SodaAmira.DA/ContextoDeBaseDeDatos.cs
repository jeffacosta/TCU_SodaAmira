using Microsoft.EntityFrameworkCore;
using System;
using TCU_SodaAmira.Models;

namespace TCU_SodaAmira.DA
{
    public class ContextoDeBaseDeDatos : DbContext
    {
        public ContextoDeBaseDeDatos() { }
        public ContextoDeBaseDeDatos(DbContextOptions<ContextoDeBaseDeDatos> opciones) : base(opciones)
        { }

        public DbSet<Inventario> Inventario { get; set; }
    }
}
