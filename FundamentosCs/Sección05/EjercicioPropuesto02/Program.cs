namespace EjercicioPropuesto02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu 1er nota");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa tu 2da nota");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa tu 3ra nota");
            int n3 = Convert.ToInt32(Console.ReadLine());

            int promedio = (n1 + n2 + n3) / 3;
            string mensaje = "";

            switch (promedio)
            {
                case > 10:
                    mensaje = "Aprobado";
                    break;

                case >= 7 and <= 10:
                    mensaje = "Desaprobado";
                    break;

                case < 7:
                    mensaje = "Reprobado";
                    break;

            };
            Console.WriteLine($"Tú promedio fué: {promedio}");
            Console.WriteLine($"Tú calificación fué: {mensaje}");

        }
    }
}
