namespace EjercicioPropuesto02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numeroMultiplo = 0;
            int numeroA = 0;
            int numeroB = 0;

            Console.WriteLine("Ingresa 1er número");
            numeroA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa 2do número");
            numeroB = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("¿En que multiplos quieres que te los muestre.");
             numeroMultiplo = Convert.ToInt32(Console.ReadLine());

            Console.Write($"\nTu resultado es: ");

            for (int i = numeroA; i <= numeroB; i+= numeroMultiplo)
            {
                if (i <= numeroB)
                {
                    Console.Write($"{i} ");
                    
                }

            }

            Console.WriteLine("\n");

            if (numeroA > numeroB)
            {
                Console.WriteLine("ERROR! El rango ingresado es invalido");
            }



        }
    }
}
