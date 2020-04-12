using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Vivas
{
    class Compartimiento
    {
        public int ID_Compartimiento { get; set; }
        public int Capacidad_Total { get; set; }
        public int Lugares_Disponibles { get; set; }
        public int Lugares_Ocupados { get; set; }
        public Producto Producto { get; set; }
    }
}
