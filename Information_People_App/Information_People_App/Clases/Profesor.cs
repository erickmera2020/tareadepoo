using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_People_App.Clases
{
    class Profesor
    {
        public string nombre;
        public string apellidos;
        public string identificacion;
        public string estado_civil;
        public string fecha_incorporacion;
        public int nro_despacho;
        public string departamento;
        public double sueldo;
        public int hora_trabajo;
        private double precio_hora = 3.5;

        public Profesor()
        {

        }

        public string estadoCivil(string NuevoEstado)
        {
            estado_civil = NuevoEstado;
            return estado_civil;
        }

        public string cambioDpto(string NuevoDpto)
        {
            departamento = NuevoDpto;
            return departamento;
        }

        public string porContrato()
        {
            nombre = "Francisco";
            apellidos = "Mejia";
            identificacion = "1923";
            estado_civil = estadoCivil(estado_civil);
            fecha_incorporacion = "21/09/2010";
            nro_despacho = 1288;
            departamento = "Ing sistemas";
            hora_trabajo = 8;
            sueldo = precio_hora * hora_trabajo;
            return listado();
        }

        public string porNombramiento()
        {
            nombre = "Juan";
            apellidos = "Marulanda";
            identificacion = "23323";
            estado_civil = "Casado";
            fecha_incorporacion = "21/09/2010";
            nro_despacho = 1288;
            departamento = "Ing sistemas";
            sueldo = 780;
            int hora_extra = 6;
            double valor_horas_extras = (precio_hora * 1.5) * hora_extra;
            sueldo = sueldo + valor_horas_extras;
            return listado();
        }

        public string listado()
        {
            return $"\n Profesor: \n Nombre: {nombre}. \n Apellidos: {apellidos}. \n Identificacion: {identificacion}. " +
                   $"\n Estado civil: {estado_civil}. \n Incorporado: {fecha_incorporacion}. \n Nro Despacho: {nro_despacho}. " +
                   $"\n Departamento: {departamento}. \n Sueldo: ${sueldo}. \n Nro Despacho: {nro_despacho}. ";
        }
    }
}
