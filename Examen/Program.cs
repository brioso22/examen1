using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int Id;
            String Código;
            String Nombre;
            String Facultad;
            double Notas;
            double Notas2;
            double Notaf;
            string Carrera;
            string Asiganatutra;

            Console.WriteLine("¿Cuantos registros desea agregar?: ");
            int registros = int.Parse(Console.ReadLine());

            Estudiantes[] arregloestudiantes = new Estudiantes[registros];


            for (int i = 0; i < registros; i++)
            {
                Id = i + 1;
                Console.WriteLine("Ingrese los siguientes datos: ");
                Console.WriteLine("Ingrese el Código:");
                Código = Console.ReadLine();
                Console.WriteLine("Ingrese el Nombre: ");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la Facultad ");
                Facultad = Console.ReadLine();
                Console.WriteLine("Ingrese el lab 1  ");
                Notas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el lab 2  ");
                Notas2 = int.Parse(Console.ReadLine());
                Notaf = (Notas + Notas2) / 2;
                Console.WriteLine("Ingresar la carrera ");
                Carrera = Console.ReadLine();
                Console.WriteLine("Ingresar la Asignatura ");
                Asiganatutra = Console.ReadLine();



                arregloestudiantes[i] = new Estudiantes(Id, Código, Nombre, Facultad, Notas, Notas2, Notaf, Carrera, Asiganatutra);
            }

            // REALIZAR CONSULTAS
            int con = 1;

            while (con == 1)
            {
                int datoint, op;


                Console.WriteLine("------------------- UN GUSTO -----------------------------");
                Console.WriteLine("-------------- SELECCIONE UNA OPCION----------------------");
                Console.WriteLine("1. BUSCAR POR CODIGO....................................");
                Console.WriteLine("2. BUSCAR POR ESTUDIANTES REPROBADOS......................");
                Console.WriteLine("3. BUSCAR ESTUDIANTES APROBADOS ..........................");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {

                    Console.WriteLine("Digite el código que busca: ");
                    Código = Console.ReadLine();

                    IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                   where estudiante.Código == Código
                                                                   select estudiante;
                    Console.WriteLine("El resultado de la consulta es: ");
                    foreach (Estudiantes consulta in consultaestudiantes)
                    {
                        Console.WriteLine(consulta.mostrar());

                    }

                }

                else if (op == 2)
                {


                    datoint = 6;

                    IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                   where estudiante.Notaf <= datoint
                                                                   select estudiante;
                    Console.WriteLine("El resultado de la consulta es: ");
                    foreach (Estudiantes consulta in consultaestudiantes)
                    {
                        Console.WriteLine(consulta.mostrar());

                    }
                }
                else if (op == 3)
                {

                    {


                        datoint = 6;

                        IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                       where estudiante.Notaf > datoint
                                                                       select estudiante;
                        Console.WriteLine("El resultado de la consulta es: ");
                        foreach (Estudiantes consulta in consultaestudiantes)
                        {
                            Console.WriteLine(consulta.mostrar());

                        }
                    }


                }
                Console.WriteLine("Digite 1 si desea consultar nuevamente y cualquier otro numero si no desea consultar:  ");
                con = int.Parse(Console.ReadLine());

            }


            Console.Read();

        }

    }

}
