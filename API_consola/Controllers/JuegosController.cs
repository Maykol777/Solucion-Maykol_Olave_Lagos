using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_consola.Models;

namespace API_consola.Controllers
{
    public class JuegosController : ApiController
    {
        Consola_bd bd = new Consola_bd();
        // GET: api/Juegos
        public IEnumerable<Juego> Get()
        {
            IEnumerable<Juego> juego = bd.Juegos;
            return bd.Juegos;
        }

        // GET: api/Juegos/5
        public Juego Get(int id)
        {
            Juego J = bd.Juegos.Find(id);
            return J;
        }

        // POST: api/Juegos
        public String Post (Juego nuevo)
        {
            if (ModelState.IsValid)
            {
                bd.Juegos.Add(nuevo);
                bd.SaveChanges();
                return "Los datos fueron insertados con exito";
            }
            else
            {
                return "Los datos enviados no cumplen con la estrucura definida";
            }
        }

        // PUT: api/Juegos/5
        public void Put(int id, Juego jEnviado)
        {
            if (ModelState.IsValid)
            {
                Juego jEdit = bd.Juegos.Find(id);
                //Editar sus atributos
                jEdit.id = jEnviado.id;
                jEdit.nombre = jEnviado.nombre;
                jEdit.plataforma = jEnviado.plataforma;
                jEdit.precio = jEnviado.precio;
                jEdit.anio = jEnviado.anio;
                jEdit.restriccion = jEnviado.restriccion;
                jEdit.stock = jEnviado.stock;

                bd.SaveChanges();
            }

        }

        // DELETE: api/Juegos/5
        public string Delete(int id)
        {
            Juego BorrarDato = bd.Juegos.Find(id);
            bd.Juegos.Remove(BorrarDato);
            bd.SaveChanges();

            return "Se elimino el juego: " + BorrarDato.nombre + (" ") + BorrarDato.plataforma;
        }
    }
}
