/*
  Hacer un programa que genere una matriz de 3x3, 
  que asigne ceros a todos los elementos,
  excepto a los de la diagonal principal,
  que a estos les ponga unos y que imprima la matriz
 */

namespace EPropuesto04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar el arreglo
            int[,] matriz = new int[3, 3];

            //Recorremos el arreglo
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    if (fila == columna)
                    {
                        matriz[fila, columna] = 1;
                    }
                    else
                    {
                        matriz[fila, columna] = 0;
                    }
                    Console.Write($"{matriz[fila, columna]}");
                }
                Console.WriteLine();
            }
 
        }
    }
}
