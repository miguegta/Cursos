/*
  Escriba un programa que almacene números aleatorios en un arreglo. 
  Mostar los números del arreglo. 
  Sumar los números pares y restar los impares.
  Mostrar el resultado final.
 */

namespace EPropuesto01
{
    internal class Program
    {
        static void Main(string[]args)
        {
            //Inicializar el generador random
            Random random = new();

            //Declarar el arreglo
            int[] numbers = new int[7];

            double resultado = 0;
            double sumaPares = 0;
            double restaImpares = 0;

            //Recorrer, sumar y restar arreglo
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 11);
                Console.Write($"{numbers[i]}\t");

                if (numbers[i] % 2 == 0)
                {
                    sumaPares += numbers[i];
                }
                else
                {
                    restaImpares -= numbers[i];
                }
            }
            //Mostrar resultados
            Console.WriteLine();

            resultado = sumaPares + restaImpares;

            Console.WriteLine($"\nSuma números pares: {sumaPares}");
            Console.WriteLine($"Resta números impares: {restaImpares}");
            Console.WriteLine($"El resultado final es: {resultado}");
        }
    }
}
