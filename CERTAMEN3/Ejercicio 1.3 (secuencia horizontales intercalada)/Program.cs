using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1._3__secuencia_horizontales_intercalada_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dado una matriz n x n ingresada por el usuario realizar las siguientes secuencias

            //secuencia (Horizontales intercaladas)

            int[,] mat = new int[6, 6];
            int contador = mat.GetLength(0);

            for (int i = 0; i < mat.GetLength(0); i++)
            {



                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i != 0 && i != 2 && i != 4)
                    {
                        mat[i, j] = 0;

                    }

                    else
                    {

                        mat[i, j] = 1;
                    }

                    Console.Write("{0}  ", mat[i, j]);
                }

                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
