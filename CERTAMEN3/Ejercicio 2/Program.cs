using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Solicite al Usuario la cantidad de n números, almacenar los números en un vector. 
            //mostrar luego por pantalla el número mayor, número menor y el vector ordenado de menor a mayor.

            Console.WriteLine("Sr. Usuario, averigüe el número menor, el número mayor y los números ordenados de menor a mayor.");
            Console.WriteLine("**********************     PRESIONE >>>>ENTER<<<< PARA CONTINUAR         ************************");
            Console.ReadLine();

           

            //declaracion de variables

            
            int menor = 0;
            int mayor = 0;
            

            Console.Write(">>>>  Ingrese cantidad de números que necesita consultar: ");
            
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int[] vector = new int[x];

            //llenado de vector
           
            for ( int i = 0; i < vector.Length; i++)
            {
                
                Console.Write(">>>>  Ingrese "+ (i+1)+ "° número: ");
                vector[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    mayor = vector[i];
                    menor = vector[i];

                }

                else if (vector[i] != 0)
                {
                    if (vector[i] < menor)
                    {
                        menor = vector[i];
                    }

                    if (vector[i] > mayor)
                    {
                        mayor = vector[i];
                    }

               }
               
            }

            Console.WriteLine("");
            Console.WriteLine(">>> Su número menor ingresado es: " + menor);
            Console.WriteLine(">>> Su número mayor ingresado es: " + mayor);
            Console.WriteLine("");
            Console.WriteLine(">>> Sus números ingresados de menor a mayor <<<");
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i; j < vector.Length; j++)
                {
                    int orden;
                    if (vector[i] > vector[j])

                    {
                        orden = vector[i];
                        vector[i] = vector[j];
                        vector[j] = orden;

                    }
                }
                Console.Write(" | "+vector[i]+" | ");
            }


                Console.ReadKey();
        }
        
        }
    }
