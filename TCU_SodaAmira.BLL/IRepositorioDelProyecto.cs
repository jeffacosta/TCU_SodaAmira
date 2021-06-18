using System;
using System.Collections.Generic;
using System.Text;
using TCU_SodaAmira.Models;

namespace TCU_SodaAmira.BLL
{
    public interface IRepositorioDelProyecto
    {
        public List<Inventario> ObtenerTodoElInventario();
    }
}
