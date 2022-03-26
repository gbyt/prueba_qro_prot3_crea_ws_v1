using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace prueba_qro_prot3
{
    /// <summary>
    /// Descripción breve de prototipo3
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class prototipo3 : System.Web.Services.WebService
    {
        
        [WebMethod]
        public float Suma(float a, float b)
        {
            return a + b;
        }
        [WebMethod]
        public float Resta(float a, float b)
        {
            return a - b;
        }
        [WebMethod]
        public float Multiplica(float a, float b)
        {
            return a * b;
        }
        [WebMethod]
        public float Divide(float a, float b)
        {
            return a / b;
        }
    }
}
