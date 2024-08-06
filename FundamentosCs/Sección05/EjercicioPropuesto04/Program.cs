namespace EjercicioPropuesto04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa las horas trabajadas en la semana");
            double totalHoras = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa el salario por hora");
            double salarioHora = Convert.ToDouble(Console.ReadLine());

            double salarioTotal;
            double horasExtras = 0;

            if (totalHoras > 40)
            {
                horasExtras = totalHoras - 40;
                if (horasExtras > 8)
                {
                    double tripleHorasExtras = horasExtras - 8;
                    salarioTotal = (40 * salarioHora) + (8 * (salarioHora * 2)) +
                        (tripleHorasExtras * (salarioHora * 3));

                }
                else
                {
                    salarioTotal = (40 * salarioHora) + (horasExtras * (salarioHora * 2));
                }
            }
            else
            {
                salarioTotal = totalHoras * salarioHora;
            }

            Console.WriteLine($"El trabajador acumuló un total de {totalHoras} horas trabajadas.");
            Console.WriteLine($"El pago de una hora normal es de : {salarioHora:C}.");
            Console.WriteLine($"El pago final que recibirá el trabajador es de: {salarioTotal:C}.");
        }


    }
}

