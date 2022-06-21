using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Net.Http;

namespace WebAPI_Guarderia.Controllers
{
    public class niñosController : ApiController
    {
        [System.Web.Http.HttpPost]
        // GET: Producto
        public IHttpActionResult Add()
        {
            using (Models.BDDguarderiaEntities db = new Models.BDDguarderiaEntities())
            {

                var oNiños = new Models.niños();
                oNiños.nombre = "Jose";
                oNiños.apellido = "Hernandez";
                oNiños.edad = 9;
                oNiños.sexo = "Masculino";
                db.niños.Add(oNiños);
                db.SaveChanges();
            }
            return Ok("Hecho");
        }
    }

}
