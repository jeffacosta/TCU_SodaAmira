using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCU_SodaAmira.BLL;
using TCU_SodaAmira.Models;

namespace TCU_SodaAmira.UI.Controllers
{
    public class InvenarioController : Controller
    {
        private readonly IRepositorioDelProyecto Repositorio;

        public InvenarioController(IRepositorioDelProyecto repositorio)
        {
            Repositorio = repositorio;
        }

        // GET: InventarioController
        public ActionResult Index()
        {
            List<Inventario> inventarios;

            inventarios = Repositorio.ObtenerTodoElInventario();

            return View(inventarios);
        }

        // GET: InventarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InventarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InventarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InventarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InventarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InventarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InventarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
