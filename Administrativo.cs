using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3_programacion2
{
    internal class Administrativo : Empleado
    {
        public Administrativo(string _nombre, string _apellidos, int _edad) : 
            base(_nombre, _apellidos,  _edad, es_administrativo:true) { }
    }
}
