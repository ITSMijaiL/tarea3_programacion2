using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3_programacion2
{
    internal class Estudiante : MiembroDeLaComunidad
    {
        bool ex_estudiante { get; set; } = false;
        public Estudiante(string _nombre, string _apellidos, string _cedula, int _edad, bool es_ex) 
            : base(_nombre, _apellidos, _cedula, _edad){
            ex_estudiante = es_ex;
        }
    }
}
