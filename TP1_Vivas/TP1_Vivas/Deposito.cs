using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Vivas
{
    class Deposito
    {
        public int ID_deposito { get; set; }
        public float Tamanio { get; set; }
        public int cant_Empleados { get; set; }
        public int Cantidad_Elevadores { get; set; }
        public Pasillo Pasillo { get; set; }
        public Domicilio Domicilio { get; set; }
        public Cliente Cliente { get; set; }
    }
}
