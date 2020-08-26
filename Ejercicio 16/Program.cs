using Ejercicio_16;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] miAlumno = new Alumno[3];
            miAlumno[0] = new Alumno();
            miAlumno[1] = new Alumno();
            miAlumno[2] = new Alumno();

            byte auxNota1;
            byte auxNota2;
            
            miAlumno[0].SetNombre("Pepito");
            miAlumno[0].SetApellido("Gomez");
            miAlumno[0].SetLegajo(123);
            miAlumno[1].SetNombre("Juancito");
            miAlumno[1].SetApellido("Rodriguez");
            miAlumno[1].SetLegajo(456);
            miAlumno[2].SetNombre("Pedrito");
            miAlumno[2].SetApellido("Gonzalez");
            miAlumno[2].SetLegajo(789);

            foreach  (Alumno auxAlumno in miAlumno)
            {
                Console.WriteLine("Ingrese nota 1:");
                auxNota1 =byte.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese nota 2:");
                auxNota2 = byte.Parse(Console.ReadLine());

                auxAlumno.Estudiar(auxNota1, auxNota2);
            }

        }
    }
}
