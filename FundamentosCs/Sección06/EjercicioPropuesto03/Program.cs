namespace EjercicioPropuesto03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cantidadAlumnos = 0;
            double notasFinales = 0;
            double sumaNotas = 0;
            double promedio = 0;

            Console.WriteLine("Ingresa la cantidad de alumnos");
            cantidadAlumnos = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= cantidadAlumnos; i++)
            {
                Console.WriteLine($"Ingresa la nota del alumno {i}");
                notasFinales = Convert.ToDouble(Console.ReadLine());

                sumaNotas += notasFinales;
            }
            
            promedio = sumaNotas / cantidadAlumnos;

            Console.WriteLine("\n");
            Console.WriteLine($"La cantidad de alumnos fueron: {cantidadAlumnos}");
            Console.WriteLine($"El promedio final de los alumnos fue: {promedio:0.##}");

        }
    }
}
