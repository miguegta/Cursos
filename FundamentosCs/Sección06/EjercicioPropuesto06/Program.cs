namespace EjercicioPropuesto06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Ingresa la altura de la figura.");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write($"{i}");
                }

                Console.WriteLine();
            }


        }
    }
}
