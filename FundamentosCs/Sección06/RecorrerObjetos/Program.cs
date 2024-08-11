/*
  Programa que indica si un correo es valido
  según si cuenta con @ y .com
 */

string correo = "";
bool tieneArroba = false;

Console.WriteLine("Ingrese su correo: ");
correo = Console.ReadLine();

for (int i = 0; i < correo.Length; i++)
{
    if (correo[i] == '@' )
    {
        tieneArroba = true;
    }
}

if (tieneArroba)
{
    if (correo.Contains(".com"))
    {
        Console.WriteLine("Correo valido!");
    }
    else
    {
        Console.WriteLine("Correo invalido, faltan caracteres");
    }
}
else
{
    Console.WriteLine("Este correo no es valido, Ingresa un correo valido.");
}