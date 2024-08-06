namespace EjercicioPropuesto01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del trabajador.");
            string trabajador = Console.ReadLine();

            Console.WriteLine("Ingrese las horas trabajadas en la semana");
            int horasTrabajadas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la hora de trabajo");
            int valorHora = Convert.ToInt32(Console.ReadLine());

            double horasSemanales = 48;
            double pagoFinal = horasSemanales * valorHora;

            if (horasTrabajadas > horasSemanales)
            {
                double horaExtra = horasTrabajadas - horasSemanales;
                pagoFinal += (horaExtra * (valorHora * 1.5));
            }

            Console.WriteLine($"El sueldo final es: {pagoFinal}");
        }
    }
}
