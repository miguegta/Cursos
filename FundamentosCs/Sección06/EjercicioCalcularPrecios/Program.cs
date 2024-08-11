/*
  Cree un programa que le pida al usuario
  registrar productos y sus precios.
  Cada vez que el usuario termine de registrar un producto,
  el programa le debe preguntar si desea registrar otro producto más,
  si el usuario dice que sí, el programa le debe pedir registrar otro producto.
  En caso contrario, el programa le mostrará cuántos productos ha registrado 
  y el promedio.
 */

string nombre = "";
double precio = 0;
string respuesta = "";
int cantidad = 0;
double sumaTotal = 0;

do
{
    //Info
    cantidad++;
    Console.WriteLine($"Producto N° {cantidad}");
    Console.WriteLine("Ingresa el nombre del producto: ");
    nombre = Console.ReadLine();

    //Precio
    Console.WriteLine("Ingresa el precio: ");
    precio = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"Se ingresó producto: {nombre} con precio: {precio:C}");
    sumaTotal += precio;

    Console.WriteLine("¿Desea ingresar un nuevo producto?\n1. Si\n2. No");
    respuesta = Console.ReadLine();

}
while (respuesta.Equals("Si", StringComparison.OrdinalIgnoreCase));

double promedio = sumaTotal / cantidad;

Console.WriteLine($"La cantidad de productos fueron: {cantidad}");
Console.WriteLine($"El promedio de precios es: {promedio}");

