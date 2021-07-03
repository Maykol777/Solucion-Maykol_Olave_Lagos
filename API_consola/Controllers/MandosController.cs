using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_consola.Models;

namespace API_consola.Controllers
{
    public class MandosController : ApiController
    {
        Consola_bd bd = new Consola_bd();
        // GET: api/Mandos
        public IEnumerable<Mando> Get()
        {
            IEnumerable<Mando> mando = bd.Mandos;
            return bd.Mandos;
        }

        // GET: api/Mandos/5
        public Mando Get(int id)
        {
            Mando M = bd.Mandos.Find(id);
            return M;
        }

        // POST: api/Mandos
        public string Post(Mando nuevo)
        {
            if (ModelState.IsValid)
            {
                bd.Mandos.Add(nuevo);
                bd.SaveChanges();
                return "Los datos fueron insertados con exito";
            }
            else
            {
                return "Los datos enviados no cumplen con la estrucura definida";
            }
        }

        // PUT: api/Mandos/5
        public void Put(int id, Mando mEnviado)
        {
            if (ModelState.IsValid)
            {
                Mando mEdit = bd.Mandos.Find(id);
                //Editar sus atributos
                mEdit.id = mEnviado.id;
                mEdit.marca = mEnviado.marca;
                mEdit.modelo = mEnviado.modelo;
                mEdit.precio = mEnviado.precio;
                mEdit.stock = mEnviado.stock;

                bd.SaveChanges();
            }
        }

        // DELETE: api/Mandos/5
        public string Delete(int id)
        {
            Mando BorrarDato = bd.Mandos.Find(id);
            bd.Mandos.Remove(BorrarDato);
            bd.SaveChanges();

            return "Se elimino el mando " + BorrarDato.marca + (" ") +BorrarDato.modelo;
        }
    }
}
