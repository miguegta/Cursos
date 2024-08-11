namespace EjercicioPropuesto04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numeroEntero = 0;
            double sumaDivisores = 0;

            Console.WriteLine("Ingresa un número positivo.");
            numeroEntero = Convert.ToDouble(Console.ReadLine());

            Console.Write("El resultado de los divisores fue: ");

            for (double i = 1; i <= numeroEntero; i++)
            {
                if (numeroEntero % i == 0)
                {
                    Console.Write($"{i} ");
                    sumaDivisores += i;
                }  
            }

            Console.WriteLine($"\nEl numero que ingresaste fue: {numeroEntero}");
            Console.WriteLine($"El resultado de la suma es: {sumaDivisores}");


        }
    }
}
