namespace EjercicioPropuesto05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double serie = 0;
            double e = 1.0;
            double factorial = 1.0;

            Console.WriteLine("Ingresa la cantidad de la serie");
            serie = Convert.ToDouble(Console.ReadLine());

            for (double i = 1; i <= serie; i++)
            {
                factorial *= i;
                e += 1 / factorial;
                Console.WriteLine($"e += 1 / {factorial}");
            }

            Console.WriteLine($"La cantidad de la serie es: {serie}");
            Console.WriteLine($"El valor estimado de 'e' es: {e} ");

        }
    }
}
