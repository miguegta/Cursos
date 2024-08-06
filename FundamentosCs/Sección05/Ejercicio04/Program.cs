//Es un programa que muestra el número mayor de 3 números.
int n1;
int n2;
int n3;

Console.WriteLine($"Ingresa el 1er número: ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ingresa el 2do número: ");
n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ingresa el 3er número: ");
n3 = Convert.ToInt32(Console.ReadLine());

//Primero tratamos los casos de n1 con n2 y n3.
if (n1 > n2)
{
    if (n1 > n3)
    {
        Console.WriteLine($"El mayor es: {n1}");
    }
    else
    {
        Console.WriteLine($"El mayor es: {n3}");
    }
}
else //O bien n2 o n3 es el mayor.
{
    if(n2 > n3)
    {
        Console.WriteLine($"El mayor es: {n2}");
    }
    else
    {
        Console.WriteLine($"El mayor es: {n3}");
    }
    
}