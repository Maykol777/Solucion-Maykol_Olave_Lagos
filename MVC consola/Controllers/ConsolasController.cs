using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_consola.Models;

namespace MVC_consola.Controllers
{
    public class ConsolasController : Controller
    {
        Consola_bd bd = new Consola_bd();
        // GET: Consolas
        public ActionResult Index()
        {
            IEnumerable<Consola>consola  = bd.Consolas;

            return View(consola);
        }

        // GET: Consolas/Details/5
        public ActionResult Details(int id)
        {
            Consola consola_buscado = bd.Consolas.Find(id);

            return View(consola_buscado);
        }

        // GET: Consolas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consolas/Create
        [HttpPost]
        public ActionResult Create(Consola new_consola)
        {
            try
            {
                // TODO: Add insert logic here
                bd.Consolas.Add(new_consola);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consolas/Edit/5
        public ActionResult Edit(int id)
        {
            Consola consola_buscado = bd.Consolas.Find(id);

            return View(consola_buscado);
        }

        // POST: Consolas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Consola consola)
        {
            try
            {
                // TODO: Add update logic here
                Consola consola_buscado = bd.Consolas.Find(id);

                consola_buscado.marca = consola.marca;
                consola_buscado.modelo = consola.modelo;
                consola_buscado.nueva = consola.nueva;
                consola_buscado.precio = consola.precio;
                consola_buscado.stock = consola.stock;
                consola_buscado.anio = consola.anio;
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consolas/Delete/5
        public ActionResult Delete(int id)
        {
            Consola consola_buscado = bd.Consolas.Find(id);
            return View(consola_buscado);
        }

        // POST: Consolas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Consola consola_buscado = bd.Consolas.Find(id);
                bd.Consolas.Remove(consola_buscado);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
