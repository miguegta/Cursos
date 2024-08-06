namespace EjercicioPropuesto05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el dato de tipo enfermedad: (0) (1) (2) (3)");
            double tipoEnfermedad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la edad del paciente: ");
            double edad = Convert.ToDouble(Console.ReadLine());

            double costoDiario = 0;
          

            switch (tipoEnfermedad)
            {
                case 0:
                    costoDiario = 25;
                    break;

                case 1:
                    costoDiario = 16;
                    break;

                case 2:
                    costoDiario = 20;
                    break;

                case 3:
                    costoDiario = 32;
                    break;

                default:
                    Console.WriteLine("Ingrese un tipo de enfermedad valida");
                    break;
            }

            if (edad is >= 14 and <= 22)
            {
                costoDiario *= 1.1;
            }

            double costoTotal = costoDiario * 10;
            Console.WriteLine($"El costo total de internamiento es: {costoTotal:C}");
        }
    }
}
