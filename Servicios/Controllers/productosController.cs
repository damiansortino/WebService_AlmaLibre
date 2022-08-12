using Servicios.Clases;
using Servicios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Servicios.Controllers
{
    public class productosController : ApiController
    {
        // GET: api/productos
        public List<prod> Get()
        {
            List<prod> listado = new List<prod>();
            using (baselaymarEntities db = new baselaymarEntities())
            {
                foreach (var item in db.producto)
                {
                    if (item.fechaBaja != null)
                    {
                        prod nuevoprod = new prod(item);
                        listado.Add(nuevoprod);
                    }
                }
            }
            return listado;
        }

        // GET: api/productos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/productos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/productos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/productos/5
        public void Delete(int id)
        {
        }
    }
}
