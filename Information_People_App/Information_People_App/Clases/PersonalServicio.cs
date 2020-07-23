using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_People_App.Clases
{
    class PersonalServicio
    {
        public List<string> elementos = new List<string>();
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string identificacion { get; set; }
        public string estado_civil { get; set; }
        public string fecha_incorporacion { get; set; }
        public int nro_despacho { get; set; }
        public string seccion { get; set; }

        public PersonalServicio()
        {
        }

        public string estadoCivil(string id, string NuevoEstado)
        {
            
            return "";
        }

        public string trasladoSeccion(string nuevaSeccion)
        {
            seccion = nuevaSeccion;
            return "";
        }

        public Boolean addPersonaServ()
        {
            try
            {
                elementos.Add(nombre);
                elementos.Add(apellidos);
                elementos.Add(identificacion);
                elementos.Add(estado_civil);
                elementos.Add(fecha_incorporacion);
                elementos.Add(Convert.ToString(nro_despacho));
                elementos.Add(seccion);

                return true;
            } catch(Exception ex)
            {
                return false;
            }
        }

        public List<string> listadoP()
        {
            return elementos;
        }
    }
}
