// Expresión booleana ? sentencia 1 : sentencia 2;

int valor = 8;
int num;

Console.WriteLine("Adivina un número del 1 al 10:");
num = Convert.ToInt32(Console.ReadLine());

if (num == valor)
{
    Console.WriteLine("Correcto!");
}
else
{
    Console.WriteLine("Incorrecto.");
}

//Operador Ternario
Console.WriteLine(num == valor ? "Correcto!" : "Incorrecto");

int a = 10;
int b = 20;
bool expresion = a > b;
string verdad = "A es mayor que b";
string falso = "A no es mayor que b";
Console.WriteLine(expresion ? verdad : falso);