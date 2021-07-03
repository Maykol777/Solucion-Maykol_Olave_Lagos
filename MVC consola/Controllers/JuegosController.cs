using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_consola.Models;

namespace MVC_consola.Controllers
{

    public class JuegosController : Controller
    {
        Consola_bd bd = new Consola_bd();

        // GET: Juegos
        public ActionResult Index()
        {
            IEnumerable<Juego> juego = bd.Juegos;

            return View(juego);
        }

        // GET: Juegos/Details/5
        public ActionResult Details(int id)
        {
            Juego juego_buscado = bd.Juegos.Find(id);

            return View(juego_buscado);
        }

        // GET: Juegos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Juegos/Create
        [HttpPost]
        public ActionResult Create(Juego new_juego)
        {
            try
            {
                // TODO: Add insert logic here
                bd.Juegos.Add(new_juego);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juegos/Edit/5
        public ActionResult Edit(int id)
        {
            Juego juego_buscado = bd.Juegos.Find(id);

            return View(juego_buscado);
        }

        // POST: Juegos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Juego juego)
        {
            try
            {
                // TODO: Add update logic here
                Juego juego_buscado = bd.Juegos.Find(id);

                // aplicar cambios en sus propiedades

                juego_buscado.nombre = juego.nombre;
                juego_buscado.plataforma = juego.plataforma;
                juego_buscado.precio = juego.precio;
                juego_buscado.restriccion = juego.restriccion;
                juego_buscado.stock = juego.stock;
                juego_buscado.anio = juego.anio;
                

                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juegos/Delete/5
        public ActionResult Delete(int id)
        {
            Juego juego_buscado = bd.Juegos.Find(id);
            return View(juego_buscado);
        }

        // POST: Juegos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Juego juego_buscado = bd.Juegos.Find(id);
                bd.Juegos.Remove(juego_buscado);
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
