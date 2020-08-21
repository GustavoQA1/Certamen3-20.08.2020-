using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {


            //Cree una matriz para almacenar N registros con los siguientes campos:
            // Nombre
            // Apellido
            // Sexo(F - M)
            // Año de nacimiento
            // Mostrar al finalizar por pantalla la siguiente información
            //o Listado de todos los datos
            //o Cantidad de Hombres y Mujeres
            //o Cantidad de Mayores y Menores de Edad.

            Console.WriteLine("****    MATRIZ DE ALMACENAMIENTO DE DATOS      *****");
            Console.WriteLine("****   PRESIONE >>>>  ENTER  <<<< PARA INGRESAR   *****");
            Console.ReadLine();

            //declaracion de variables

            int vector;
            int hombre = 0;
            int mujer = 0;
            int mayor = 0;
            int menor = 0;


            Console.Write(">>> Ingrese la cantidad de usuarios que necesita registrar: ");
            vector = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");


            string[,] usuarios = new string[vector, 4];

            for (int i = 0; i < vector; i++)
            {
                Console.Write("Ingrese el nombre: ");
                usuarios[i, 0] = Console.ReadLine();

                Console.Write("Ingrese el apellido: ");
                usuarios[i, 1] = Console.ReadLine();

                Console.Write("ingrese el sexo (M | F): ");
                usuarios[i, 2] = Console.ReadLine().ToUpper();

                if (String.Compare(usuarios[i, 2], "F") == 0)
                {
                    mujer++;
                }
                else if (String.Compare(usuarios[i, 2], "M") == 0)
                {
                    hombre++;
                }

                Console.Write("Ingrese el año de nacimiento: ");
                usuarios[i, 3] = Console.ReadLine();

                if (String.Compare(usuarios[i, 3], "2002") <= 0)
                {
                    mayor++;
                }
                else if (String.Compare(usuarios[i, 3], "2002") > 0)
                {
                    menor++;
                }

                Console.WriteLine("");

            }

            for (int i = 0; i < vector; i++)
            {
                Console.WriteLine(">>>> Registro N°" + (i + 1) + " <<<<<");
                Console.WriteLine("- Nombre            : " + usuarios[i, 0]);
                Console.WriteLine("- Apellido          : " + usuarios[i, 1]);
                Console.WriteLine("- Sexo              : " + usuarios[i, 2]);
                Console.WriteLine("- Año de Nacimiento : " + usuarios[i, 3]);
                Console.WriteLine("");
            }


            Console.WriteLine(">>>>> ESTADÍSTICA DE REGISTRADOS <<<<<");
            Console.WriteLine("***************************************");
            Console.WriteLine(">>> Cantidad de Hombres      : " + hombre);
            Console.WriteLine(">>> Cantidad de Mujeres      : " + mujer);
            Console.WriteLine(">>> Cantidad Mayores de edad : " + mayor);
            Console.WriteLine(">>> Cantidad Menores de edad : " + menor);
            Console.ReadKey();
        }
    }
}
