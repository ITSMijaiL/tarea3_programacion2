using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3_programacion2
{
    internal class MiembroDeLaComunidad
    {
        protected string nombre, apellidos;
        protected int edad;
        public MiembroDeLaComunidad(string _nombre, string _apellidos,  int _edad) {
            nombre = _nombre;
            apellidos = _apellidos;
            edad = _edad;
        }
    }
}
