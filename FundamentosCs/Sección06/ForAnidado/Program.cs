//Imprimir la tabla de multiplicar de "x" numeros "y"

Console.WriteLine("Ingresa el 1er valor: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa el 2do valor: ");
int y = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    for (int j = 1; j <= y; j++)
    {
        int multi = i * j;
        Console.WriteLine($"{i}x{j} = {multi}");
    }
    Console.WriteLine();
}