using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n\n\n");

            int n;
            Console.Write("n=: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nIngrese los datos\n");

            // Matriz nx4 de 100 caracteres de longitud
            String[,] strmat = new String[n, 4];

            int cant_hom = 0;
            int cant_muj = 0;
            int cant_may = 0;
            int cant_men = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nNombre= ? ");
                strmat[i, 0] = Console.ReadLine();

                Console.Write("\nApellido= ? ");
                strmat[i, 1] = Console.ReadLine();

                Console.Write("\nSexo[F/M]= ? ");
                strmat[i, 2] = Console.ReadLine().ToUpper();

                if (String.Compare(strmat[i, 2], "F") == 0)
                {
                    cant_muj++;
                }
                else if (String.Compare(strmat[i, 2], "M") == 0)
                {
                    cant_hom++;
                }

                Console.Write("\nNacimiento= ? ");
                strmat[i, 3] = Console.ReadLine();

                if (String.Compare(strmat[i, 3], "2002") <= 0)
                {
                    cant_may++;
                }
                else if (String.Compare(strmat[i, 3], "2002") > 0)
                {
                    cant_men++;
                }
            }

            Console.WriteLine("\n\nDatos registrados\n\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n\nIndice: " + (i + 1));
                Console.Write("\nNombre: " + strmat[i, 0]);
                Console.Write("\nApellido: " + strmat[i, 1]);
                Console.Write("\nSexo: " + strmat[i, 2]);
                Console.Write("\nNacimiento: " + strmat[i, 3]);
            }

            Console.Write("\n\nResumen");
            Console.Write("\nCantidad Mujeres: " + cant_muj);
            Console.Write("\nCantidad Hombres: " + cant_hom);
            Console.Write("\n\nCantidad Mayores de edad: " + cant_may);
            Console.Write("\nCantidad Menores de edad: " + cant_men);

            Console.WriteLine("\n\nThat's all folks\n");
            Console.ReadKey();
        }
    }
}
