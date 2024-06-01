using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3_programacion2
{
    enum tipo_empleado{
        Docente,
        Administrativo
    }
    internal class Empleado : MiembroDeLaComunidad
    {
        tipo_empleado tipo_de_empleado;
        public Empleado(string _nombre, string _apellidos, int _edad, bool es_administrativo) 
            : base(_nombre, _apellidos, _edad) {
            tipo_de_empleado = es_administrativo ? tipo_empleado.Administrativo : tipo_empleado.Docente;
        }
    }
}
