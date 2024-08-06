/*
    && - AND - Y
     A B | R
     F F = F
     F V = F
     V F = F
     V V = V  -> TRUE si y solo si ambos son verdaderos
*/

//Programa que verifica si 2 números son mayores que 0
int num1;
int num2;
Console.WriteLine($"Introduce el 1er número");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Introduce el 2do número");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > 0 && num2 > 0)
{
    //Console.WriteLine($"Los num ingresados son mayores que 0");
}
else
{
    //Console.WriteLine($"Los num ingresados no son mayores que 0");
}

//Extra: Comprobar si son menores que 10.

if ((num1 > 0 && num2 > 0) && (num1 < 10 && num2 < 10))
{
    //Console.WriteLine($"Se cumple");
}
else
{
    //Console.WriteLine($"No se cumple");
}

//Extra: Como hacerlo más corto usando "is" y "and"

if (num1 is > 0 and < 10 && num2 is > 0 and < 10)
{
    Console.WriteLine($"Se cumple");
}
else
{
    Console.WriteLine($"No se cumple");
}








