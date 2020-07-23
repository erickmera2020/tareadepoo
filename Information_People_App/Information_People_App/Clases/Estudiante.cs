using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_People_App.Clases
{
    class Estudiante
    {
        public List<string> elementos = new List<string>();
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string identificacion { get; set; }
        public string estado_civil { get; set; }
        public string curso_matriculado { get; set; }


        public Estudiante()
        {
        }

        //public string estadoCivil(string NuevoEstado)
        //{
        //}

        public Boolean matriculaCurso()
        {
            try
            {
                elementos.Add(nombre);
                elementos.Add(apellidos);
                elementos.Add(identificacion);
                elementos.Add(estado_civil);
                elementos.Add(curso_matriculado);
         
                return true;

            } catch(Exception ex)
            {
                return false;
            }
        }

        public List<string> listado()
        {
            return elementos.ToList();
        }
    }
}
