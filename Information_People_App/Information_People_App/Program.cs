using Information_People_App.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_People_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor profesor = new Profesor();
            PersonalServicio personalS = new PersonalServicio();
            Estudiante estudiante = new Estudiante();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bienvenido al sistema de gestion de la U");
            showMenu(estudiante, personalS, profesor);
            Console.ReadKey();
        }

        static void showMenu(Estudiante estudiante, PersonalServicio personalServicio, Profesor profesor)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine("Seleccione la opción deseada");
            Console.WriteLine();
            Console.WriteLine("1.- Registrar un empleado de servicio");
            Console.WriteLine("2.- Matricular un estudiante a un curso");
            Console.WriteLine("3.- Ver profesores");
            Console.WriteLine("4.- Imprimir");

            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    createPersonal(personalServicio, estudiante, profesor);
                    break;
                case 2:
                    createMatricula(estudiante, personalServicio, profesor);
                    break;
                case 3:
                    verProfesores(estudiante, personalServicio, profesor);
                    break;
                case 4:
                    Console.WriteLine("Resultado:");
                    imprimir(estudiante, personalServicio, profesor);
                    break;
                default:
                    Console.WriteLine("No elegistes un numero correcto");
                    break;
            }
        }

        static void createPersonal(PersonalServicio personalServicio, Estudiante estudiante, Profesor profesor)
        {
            Console.WriteLine("ingrese el nombre:");
            string nombreS = Console.ReadLine();
            Console.WriteLine("ingrese el apellido:");
            string apellidoS = Console.ReadLine();
            Console.WriteLine("ingrese la identificacion:");
            string identificacionS = Console.ReadLine();
            Console.WriteLine("ingrese el estado civil:");
            string estado_civilS = Console.ReadLine();
            Console.WriteLine("ingrese la fecha:");
            string fechaS = Console.ReadLine();
            Console.WriteLine("ingrese el numero de despacho:");
            int despacho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la seccion:");
            string seccion = Console.ReadLine();

            personalServicio.nombre = nombreS;
            personalServicio.apellidos = apellidoS;
            personalServicio.identificacion = identificacionS;
            personalServicio.estado_civil = estado_civilS;
            personalServicio.fecha_incorporacion = fechaS;
            personalServicio.nro_despacho = despacho;
            personalServicio.seccion = seccion;
            var resultado = personalServicio.addPersonaServ();
            Console.WriteLine("Agregado correctamente... \n ");
            showMenu(estudiante, personalServicio, profesor);
        }

        static void createMatricula(Estudiante estudiante, PersonalServicio personalServicio, Profesor profesor)
        {
            Console.WriteLine("ingrese el nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("ingrese el apellido:");
            string apellido = Console.ReadLine();
            Console.WriteLine("ingrese la identificacion:");
            string identificacion = Console.ReadLine();
            Console.WriteLine("ingrese el estado civil:");
            string estado_civil = Console.ReadLine();
            Console.WriteLine("ingrese el nuevo curso:");
            string curso = Console.ReadLine();

            estudiante.nombre = nombre;
            estudiante.apellidos = apellido;
            estudiante.identificacion = identificacion;
            estudiante.estado_civil = estado_civil;
            estudiante.curso_matriculado = curso;
            var resultado = estudiante.matriculaCurso();
            Console.WriteLine("Agregado correctamente...");
            showMenu(estudiante, personalServicio, profesor);
        }

        static void verProfesores(Estudiante estudiante, PersonalServicio personalServicio, Profesor profesor)
        {
            Console.WriteLine("Ver por tipo de contrato \n 1. Por contrato \n 2. Por nombramiento");
            int cod = Convert.ToInt32(Console.ReadLine());
            if (cod == 1)
            {
                Console.WriteLine(profesor.porContrato());
                showMenu(estudiante, personalServicio, profesor);
            }
            else if (cod == 2)
            {
                Console.WriteLine("El profesor trabajo 6 horas extras");
                Console.WriteLine(profesor.porNombramiento());
                showMenu(estudiante, personalServicio, profesor);
            }
            else
            {
                Console.WriteLine("No hay datos!");
            }
        }

        static void imprimir(Estudiante estudiante, PersonalServicio personalServicio, Profesor profesor)
        {
            Console.WriteLine("Que deseas imprimir?");
            Console.WriteLine();
            Console.WriteLine("1.- Personal de servicio");
            Console.WriteLine("2.- Estudiantes");
            Console.WriteLine("3.- Profesores");
            
            int data = Convert.ToInt32(Console.ReadLine());
            if(data == 1)
            {
                Console.WriteLine("---- Personal de servicio ----");
                var person = personalServicio.listadoP();
                foreach (var item in person)
                {
                    Console.WriteLine(item);
                }
            } else if(data == 2)
            {
                var student = estudiante.listado();
                Console.WriteLine("---- Estudiantes ----");
                foreach (var item in student)
                {
                    Console.WriteLine(item);
                }
            } else if(data == 3)
            {
                Console.WriteLine("---- Profesor Por contrato ----");
                Console.WriteLine(profesor.porContrato());

                Console.WriteLine("---- Profesor Por nombramiento ----");
                Console.WriteLine(profesor.porNombramiento());
            }


            Console.WriteLine();
            showMenu(estudiante, personalServicio, profesor);
        }
    }
}
