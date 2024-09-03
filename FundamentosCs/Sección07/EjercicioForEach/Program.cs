/*
  Programa que ingrese ventas y calcualar la suma total,
  promedio, venta mayor y menor.
 */

//Definir nuestro arreglo
double[] ventas = new double[5];

//Solicitar las ventas
/*
  Ventas[0]
  Ventas[1]
  Ventas[2]
  Ventas[3]
  Ventas[4]
 */
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Ingresar ventas {i + 1}");
    ventas[i] = Convert.ToDouble(Console.ReadLine());
}

//Calcular total ventas
double sumaTotal = 0;
foreach (double v in ventas)
{
    sumaTotal += v;
}

//Calcualar promedio
double promVentas = sumaTotal / ventas.Length;

//Buscar venta mayor y menor
double ventaMayor = ventas[0];
double ventaMenor = ventas[0];

foreach (double v in ventas)
{
    if (v > ventaMayor)
    {
        ventaMayor = v;
    }
    if (v < ventaMenor)
    {
        ventaMenor = v;
    }
}

//Mostar resultado
Console.WriteLine($"Total ventas: {sumaTotal}");
Console.WriteLine($"Promedio ventas: {promVentas}");
Console.WriteLine($"Venta mayor: {ventaMayor}");
Console.WriteLine($"venta menor: {ventaMenor}");