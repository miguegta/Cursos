namespace EPropuesto03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar el arreglo
            int[][] ventas =
            [
                [100, 150, 200],        // Lunes
                [120, 80],              // Martes
                [180, 220, 90],         // Miércoles
                [160, 190, 100, 140],   // Jueves
                [210, 180, 120],        // Viernes
                [90, 80, 200, 170],     // Sábado
                [150, 130],             // Domingo
            ];
            int[] totalVentas = new int[7];

            //Recorrer el arreglo
            for (int dia = 0; dia < ventas.Length; dia++)
            {
                int total = 0;

                for (int producto = 0; producto < ventas[dia].Length; producto++)
                {
                    total += ventas[dia][producto];
                }
                totalVentas[dia] = total;
            }
            // Mostrar el total de ventas por día
            Console.WriteLine("Total de ventas por día:");

            string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            for (int dia = 0; dia < totalVentas.Length; dia++)
            {
                Console.WriteLine($"{diasSemana[dia]}: ${totalVentas[dia]}");
            }
        }
    }
}
