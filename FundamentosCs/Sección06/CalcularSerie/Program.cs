/*
  Pi = 4 (1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 - 15...) 
*/

int serie = 0;
double contenedor = 0;

Console.WriteLine("Ingresa el número de serie que desea ver: ");
serie = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Serie: ");

for (int i = 1; i <= serie; i++)
{
    double a = (double) 1 / (2 * i - 1);

    if (i % 2 == 0)
    {
        contenedor -= a;
        Console.WriteLine($"({i}) = -1/{(2 * i - 1)}");
    }
    else
    {
        contenedor += a;
        Console.WriteLine($"({i}) = +1/{(2 * i - 1)}");
    }
    
}

double PI = 4 * contenedor;
Console.WriteLine($"La suma es: {contenedor:0.##}");
Console.WriteLine($"La aproximación de PI es: {PI:0.##}");