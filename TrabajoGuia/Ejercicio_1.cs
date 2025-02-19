using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoGuia
{
    class Ejercicio_1
    {
        public string nombre;
        public float nota1;
        public float nota2;
        public float nota3;

        public void IngresarNotas()
        {
            Console.WriteLine("CAPTURA DE NOTAS");
            Console.Write("NOMBRE : "); nombre = Console.ReadLine();
            Console.Write("NOTA 1 : "); nota1 = float.Parse(Console.ReadLine());
            Console.Write("NOTA 2 : "); nota2 = float.Parse(Console.ReadLine());
            Console.Write("NOTA 3 : "); nota3 = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("DATOS INGRESADOS DE MANERA CORRECTA ...");
            Console.ReadKey();
        }


        private float CalcularNotaFinal()
        {
            float definitiva;

            definitiva = nota1 * 0.3f + nota2 * 0.3f + nota3 * 0.4f;
            return definitiva;
        }

        private string Estado()
        {
            if (CalcularNotaFinal() >= 3)
            {
                return "El estudiante gano la materia";
            }
            return "El estudiante perdio la materia";
        }

        public void MostrarResultados()
        {
            Console.Clear();
            Console.WriteLine($"NOMBRE : {nombre}");
            Console.WriteLine($"NOTA 1 : {nota1}");
            Console.WriteLine($"NOTA 2 : {nota2}");
            Console.WriteLine($"NOTA 3 : {nota3}");
            Console.WriteLine($"DEFINITIVA : {CalcularNotaFinal()}");
            Console.WriteLine(Estado());
            Console.ReadKey();
        }
    }
}
