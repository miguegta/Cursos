namespace EjercicioPropuesto03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu salario mensual");
            double salarioMensual = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa tu tiempo trabajando\n(1) Menos de un año\n" +
                "(2) 1 año o más y menos de 2 años\n(3) 2 años o más y menos de 5 años\n" +
                "(4) 5 años o mas y menos de 10 años\n(5) 10 años o más.");
            double tiempoTrabajando = Convert.ToDouble(Console.ReadLine());

            double utilidadTotal = 0;

            if (tiempoTrabajando == 1)
            {
                utilidadTotal = salarioMensual * 0.05;
            }
            else if (tiempoTrabajando == 2)
            {
                utilidadTotal = salarioMensual * 0.07;
            }
            else if (tiempoTrabajando == 3)
            {
                utilidadTotal = salarioMensual * 0.10;
            }
            else if (tiempoTrabajando == 4)
            {
                utilidadTotal = salarioMensual * 0.15;
            }
            else if (tiempoTrabajando == 5)
            {
                utilidadTotal = salarioMensual * 0.20;
            }

            Console.WriteLine($"Tu salario Mensual es: {salarioMensual}");
            Console.WriteLine($"Tu utilidad total es: {utilidadTotal}");
        }
    }
}
