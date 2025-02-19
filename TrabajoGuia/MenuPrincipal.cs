using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoGuia
{
    class MenuPrincipal
    {
        public void Menu()
        {
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("--- M E N U ---");
                Console.WriteLine("1) EJERCICIO CALCULAR PROMEDIO DE NOTAS ");
                Console.WriteLine("2) EJERCICIO NUMERO DE PULSACIONES");
                Console.WriteLine("3) EJERCICIO INFORMACION FINANCIERA");
                Console.WriteLine("4) SALIR");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio_1 ejercicio1 = new Ejercicio_1();
                        ejercicio1.IngresarNotas();
                        ejercicio1.MostrarResultados();
                        break;

                    case 2:
                        Console.Clear();
                        Ejercicio_2 ejercicio2 = new Ejercicio_2();
                        ejercicio2.RegistroDatos();
                        ejercicio2.ImprimirResultados();
                        break;

                    case 3:
                        Console.Clear();
                        Ejercicio_3 ejercicio3 = new Ejercicio_3();
                        ejercicio3.MenuFinanciero();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("GRACIAS POR UTILIZAR EL PROGRAMA :D");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }

            } while (op != 4);
        }
    }
}
