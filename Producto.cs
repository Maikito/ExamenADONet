﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenADONet
{
    public   class Producto
    {
        public int IdProducto { get; set; }
        public string  Nombre { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
       public DateTime FechaCreacion { get; set; } 


    }
}
