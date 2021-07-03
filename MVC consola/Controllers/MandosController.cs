using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_consola.Models;

namespace MVC_consola.Controllers
{
    public class MandosController : Controller
    {
        Consola_bd bd = new Consola_bd();
        // GET: Mandos
        public ActionResult Index()
        {
            IEnumerable<Mando> mando = bd.Mandos;

            return View(mando);
        }

        // GET: Mandos/Details/5
        public ActionResult Details(int id)
        {
            Mando mando_buscado = bd.Mandos.Find(id);

            return View(mando_buscado);
        }

        // GET: Mandos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mandos/Create
        [HttpPost]
        public ActionResult Create(Mando new_mando)
        {
            try
            {
                // TODO: Add insert logic here
                bd.Mandos.Add(new_mando);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mandos/Edit/5
        public ActionResult Edit(int id)
        {
            Mando mando_buscado = bd.Mandos.Find(id);

            return View(mando_buscado);
        }

        // POST: Mandos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Mando mando)
        {
            try
            {
                // TODO: Add update logic here
                Mando mando_buscado = bd.Mandos.Find(id);
                mando_buscado.marca = mando.marca;
                mando_buscado.modelo = mando.modelo;
                mando_buscado.precio = mando.precio;
                mando_buscado.stock = mando.stock;
                mando_buscado.compatibilidad = mando.compatibilidad;
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mandos/Delete/5
        public ActionResult Delete(int id)
        {
            Mando mando_buscado = bd.Mandos.Find(id);
            return View(mando_buscado);
        }

        // POST: Mandos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Mando mando_buscado = bd.Mandos.Find(id);
                bd.Mandos.Remove(mando_buscado);
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
