//Creación de varibles
int opcion;
double valor;
double resultado;

//Pedir info
Console.WriteLine("Selecciona la operación que desea realizar: ");
Console.WriteLine("1. Metros a milimetros");
Console.WriteLine("2. Milimetros a metros");
opcion = Convert.ToInt32(Console.ReadLine());

//Obtener valor del usuario
Console.WriteLine("Ingresa el valor");
valor = Convert.ToDouble(Console.ReadLine());

//Hacer operaciones
if (opcion == 1)
{
    resultado = valor * 1000;
    Console.WriteLine($"{valor} Metros a milimetros es: {resultado}mm");
}
if (opcion == 2)
{
    resultado = valor / 1000;
    Console.WriteLine($"{valor} Milimetros a metros es: {resultado}m");
}