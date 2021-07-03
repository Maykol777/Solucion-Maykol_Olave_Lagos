using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_consola.Models;

namespace API_consola.Controllers
{
    public class ConsolasController : ApiController
    {
        Consola_bd bd = new Consola_bd();

        // GET: api/Consolas
        public IEnumerable<Consola> Get()
        {
            IEnumerable<Consola> consola = bd.Consolas;
            return bd.Consolas;
        }

        // GET: api/Consolas/5
        public Consola Get(int id)
        {
            Consola C = bd.Consolas.Find(id);
            return C;
        }

        // POST: api/Consolas
        public String Post (Consola nuevo)
        {
            if (ModelState.IsValid)
            {
                bd.Consolas.Add(nuevo);
                bd.SaveChanges();
                return "Los datos fueron insertados con exito";
            }
            else
            {
                return "Los datos enviados no cumplen con la estrucura definida";
            }
        }

        // PUT: api/Consolas/5
        public void Put(int id, Consola cEnviado)
        {
            if (ModelState.IsValid)
            {
                Consola cEdit = bd.Consolas.Find(id);
                //Editar sus atributos
                cEdit.id = cEnviado.id;
                cEdit.marca = cEnviado.marca;
                cEdit.modelo = cEnviado.modelo;
                cEdit.nueva = cEnviado.nueva;
                cEdit.anio = cEnviado.anio;
                cEdit.precio = cEnviado.precio;
                cEdit.stock = cEnviado.stock;

                bd.SaveChanges();
            }

        }

        // DELETE: api/Consolas/5
        public string Delete(int id)
        {
            Consola BorrarDato = bd.Consolas.Find(id);
            bd.Consolas.Remove(BorrarDato);
            bd.SaveChanges();

            return "Se elimino la consola: " + BorrarDato.marca + (" ") + BorrarDato.modelo;
        }
    }
}
