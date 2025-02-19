using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoGuia
{
    class Ejercicio_2
    {
        public string nombre;
        public char sexo;
        public int edad;

        public void RegistroDatos()
        {
            Console.WriteLine("CALCULAR NUMERO PULSACIONES");
            Console.Write("NOMBRE : "); nombre = Console.ReadLine();
            Console.Write("SEXO (M/F) : ");
            do
            {
                Console.Write("\b \b");
                sexo = char.ToUpper(Console.ReadKey().KeyChar);

            } while (sexo != 'M' && sexo != 'F');

            Console.WriteLine("");
            Console.Write("EDAD : ");
            do
            {
                edad = int.Parse(Console.ReadLine());

            } while (edad <= 0 || edad >= 120);

            Console.Clear();
            Console.WriteLine("DATOS REGISTRADOS CON EXITO");
            Console.ReadKey();
        }

        private float CalcularPulsacion()
        {
            float pulsaciones;

            if (sexo == 'M')
            {
                pulsaciones = (210 - edad) / 10;
               
            } else 
            {
                pulsaciones = (220 - edad) / 10;
               
            }
            return pulsaciones;
        }

        public void ImprimirResultados()
        {
            Console.Clear();
            Console.WriteLine("--RESULTADOS--");
            Console.WriteLine($"NOMBRE : {nombre}");
            Console.WriteLine($"SEXO : {sexo}");
            Console.WriteLine($"EDAD : {edad}");
            Console.WriteLine($"PULSACIONES : {CalcularPulsacion()}");
            Console.ReadKey();
        }
       


    }
}
