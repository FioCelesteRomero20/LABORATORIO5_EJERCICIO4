using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO5_EJERCICIO4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Ingresar datos
            Console.Write("Ingrese el número límite: ");
            int limite = int.Parse(Console.ReadLine()); 
           
            Console.WriteLine("============================");
            Console.WriteLine("Escoja una opción: " +
            "\n 1: Lista de numeros pares" +
            "\n 2: Lista de numeros impares" +
            "\n 3: Lista de el factorial");

            int opcion = int.Parse(Console.ReadLine());
            long factorial = 1;
            Console.WriteLine("============================");

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("La respuesta es: ");
                    for (int i = 2; i <= limite; i++)
                    {
                        if (i % 2 == 0)
                        {
                            //Detectar si es par
                            Console.Write(i + "," );
                            // numero = numero + i;
                        }
                    }
                break;

                case 2:
                    Console.WriteLine("La respuesta es: ");
                    for (int i = 1; i <= limite; i++)
                    {
                        if (i % 2 == 1)
                        {
                            //Detectar si es impar
                            Console.Write(i + ",");
                            // numero = numero + i;
                        }
                    }
                break;

                case 3:
                   for (int i = 1; i <= limite; i++)
                    {
                        factorial = factorial* i;
                       
                    }
                   Console.WriteLine("El factorial es: " + factorial);
                break;
                    default:
                    break;
                    
            }

            Console.ReadKey();
        }
    }
}
