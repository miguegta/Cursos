//Programa que realiza un operación aritmetica

double n1 = 0;
double n2 = 0;
double resultado = 0;
int operacion = 0;

Console.WriteLine($"Que operación desea realizar?\n1. suma\n2. Resta\n3. Multiplicación\n4. División");
operacion = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ingresa el 1er valor: ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ingresa el 2do valor: ");
n2 = Convert.ToInt32(Console.ReadLine());

if (operacion == 1)       //Suma
{
    resultado = n1 + n2;
}  
else if (operacion == 2)  //Resta
{
    resultado = n1 - n2;
}
else if (operacion == 3)  //Multiplicación
{
    resultado = n1 * n2;
}
else if (resultado == 4)  //División
{
    resultado = n1 / n2;
}

Console.WriteLine($"El resultado de la operación es {resultado}");


