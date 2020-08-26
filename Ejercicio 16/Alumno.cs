using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        string apellido;
        int legajo;
        string nombre;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public void SetLegajo(int legajo)
        {
            this.legajo = legajo;
        }  
        private void SetNotas(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }
    
        public void CalcularFinal()
        {
            if(this.nota1 >= 4 && this.nota2 >=4 )
            {
                Random numeroAleatorio = new Random();  
                notaFinal=numeroAleatorio.Next(0, 10);
            }
            else
            {
                notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos) 
        {
            SetNotas(notaUno, notaDos);
            CalcularFinal();
            Console.WriteLine(Mostrar());  
        }

        public string Mostrar ()
        {
            if(notaFinal != -1)
            {
                return "Nombre:" + nombre + "\nApellido:" + apellido + "\nLegajo:" + legajo + "\nNota final:" + notaFinal+ "\n";
            }
            else
            {
                return "Nombre:" + nombre + "\nApellido:" + apellido + "\nLegajo:" + legajo + "\nNota final:Alumno desaprobado\n";
            }
        }


    }

   

}

