/*
  Generar un arreglo con números aleatorios entre 0 y 20 para una clase de N alumnos y luego mostrarlos en pantalla,
  de acuerdo con la nota obtenida, debe indicar cuántos estudiantes son:
  Deficientes 0-5
  Irregulares 6-11
  Regulares 12-14
  Buenos 15-17
  Excelentes 18-20 
 */

namespace EPropuesto02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicializar generador de números aleatorios
            Random random = new();

            //Declarar el arreglo
            int[] numbers = new int[7];

            //Inicializar contenedores
            int deficientes = 0;
            int irregulares = 0;
            int regulares = 0;
            int buenos = 0;
            int excelentes = 0;

            //Recorrer y comparar arreglo 
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 21);
                Console.Write($"{numbers[i]}\t");

                if (numbers[i] >= 0 && numbers[i] <= 5)
                {
                    deficientes++;
                }
                else if (numbers[i] >= 6 && numbers[i] <= 11)
                {
                    irregulares++;
                }
                else if (numbers[i] >= 12 && numbers[i] <= 14)
                {
                    regulares++;
                }
                else if (numbers[i] >= 15 && numbers[i] <= 17)
                {
                    buenos++;
                }
                else if (numbers[i] >= 18 && numbers[i] <= 28)
                {
                    excelentes++;
                }
            }
            Console.WriteLine();

            Console.WriteLine($"\nDeficientes: {deficientes}");
            Console.WriteLine($"Irregulares: {irregulares}");
            Console.WriteLine($"Regulares: {regulares}");
            Console.WriteLine($"Buenos: {buenos}");
            Console.WriteLine($"Excelentes: {excelentes}");
        }

    }
}

