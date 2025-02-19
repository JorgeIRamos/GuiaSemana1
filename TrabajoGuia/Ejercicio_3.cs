using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoGuia
{
    class Ejercicio_3
    {
        public string nombre;
        public double numero_cuenta;
        public float saldo_inicial;
        public float monto;

        public void MenuFinanciero()
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("--- MENU FINANCIERO ---");
                Console.WriteLine("1- INFORMACION DEL CLIENTE");
                Console.WriteLine("2- REALIZAR CONSIGNACION");
                Console.WriteLine("3- REALIZAR RETIROS");
                Console.WriteLine("4- CONSULTAR DATOS");
                Console.WriteLine("5- SALIR");
                Console.Write("SELECCIONE UNA OPCION 1-5 : "); op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        IngresarDatos();
                        break;

                    case 2:
                        Console.Clear();
                        ConsignacionDinero();
                        break;

                    case 3:
                        Console.Clear();
                        RetirarDinero();
                        break;

                    case 4:
                        Console.Clear();
                        Informacion();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("GRACIAS POR UTILIZAR NUESTRO SERVICIO");
                        Console.ReadKey();
                        break;
                }
            } while (op != 5);
        }

        public void IngresarDatos()
        {
            Console.WriteLine("--INFORMACION DEL CLIENTE--");
            Console.Write("NOMBRE : "); nombre = Console.ReadLine();
            Console.Write("NUMERO DE CUENTA : "); numero_cuenta = double.Parse(Console.ReadLine());
            Console.Write("SALDO INICIAL"); saldo_inicial = float.Parse(Console.ReadLine());
            monto = saldo_inicial;

            Console.Clear();
            Console.WriteLine("DATOS REGISTRADOS CON EXITO");
            Console.ReadKey();
        }

        public void ConsignacionDinero()
        {
           if (saldo_inicial <= 0)
            {
                Console.WriteLine("NO EXISTE SALDO INICIAL");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("-- CONSIGNACION DE DINERO --");
                float consignacion;
                Console.Write("DIGITE LA CANTIDAD A CONSIGNAR : ");

                consignacion = float.Parse(Console.ReadLine());
                monto = monto + consignacion;

                Console.Clear();
                Console.WriteLine("CONSIGNACION REALIZADA CON EXITO");
                Console.ReadKey();
            }
        }

        public void RetirarDinero()
        {
            if (saldo_inicial <= 0)
            {
                Console.WriteLine("NO EXISTE SALDO INICIAL");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("-- RETIRAR DINERO --");
                float retirar;
                Console.Write("DIGITE LA CANTIDAD A RETIRAR : ");

                retirar = float.Parse(Console.ReadLine());
                monto = monto - retirar;

                Console.Clear();
                Console.WriteLine("RETIRADA REALIZADA CON EXITO");
                Console.ReadKey();
            }
        }

        public void Informacion()
        {
            Console.WriteLine("--CONSULTAR DATOS--");
            Console.WriteLine($"NOMBRE : {nombre}");
            Console.WriteLine($"NUMERO DE CUENTA : {numero_cuenta}");
            Console.WriteLine($"SALDO : {monto}");

            Console.ReadKey();
        }
    }
}
