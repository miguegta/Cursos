//Ejemplo 01
 
for (int i = 0; i < 10; i++)
{
    //Console.WriteLine($"{i}. Me gusta programar!");
}


//Programa para calcular el factorial

Console.WriteLine("Ingresa un número");
int num = Convert.ToInt32(Console.ReadLine());
int factorial = 1;

for (int i = 1; i <= num; i++)
{
    factorial *= i;
}

Console.WriteLine($"El factorial de {num} es: {factorial}");




