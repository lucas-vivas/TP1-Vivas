using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Vivas
{
    public class Persona
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string  Apellido { get; set; }
        public int Edad { get; set; }

        public Domicilio Domicilio { get; set; }

    }
}
