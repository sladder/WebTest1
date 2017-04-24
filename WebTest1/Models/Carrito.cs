using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTest1.Models
{
    public class Carrito
    {
        public int CarritoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public float PrecioU { get; set; }

    }
}