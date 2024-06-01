using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3_programacion2
{
    enum tipo_docente
    {
        Maestro,
        Administrador
    }
    internal class Docente : Empleado
    {
        tipo_docente tipo_de_docente;
        public Docente(string _nombre, string _apellidos, int _edad, bool es_administrador)
            :base(_nombre, _apellidos, _edad, es_administrativo: false) {
            tipo_de_docente = es_administrador ? tipo_docente.Administrador : tipo_docente.Maestro;
        }
    }
}
