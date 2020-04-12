using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Vivas
{
    class Empleado : Persona
    {
        public int NroEmpleado { get; set; }
        public string Cargo { get; set; }
        public int Carga_Horaria { get; set; }
        public float Sueldo { get; set; }
        public DateTime Fecha_Alta  { get; set; }

    }
}
