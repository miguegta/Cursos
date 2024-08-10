//Ejemplo 01
int i = 1;
int suma = 0;

while (i <= 10)
{
    suma += i;
    Console.WriteLine($"{i}");
    i++;
}

Console.WriteLine($"La suma es: {suma}");

//Ejemplo 02

string claveCorrecta = "Programación";
string claveIngresada = "";

while (claveCorrecta.Equals(claveIngresada) == false)
{
    Console.WriteLine("Ingresa la contraseña: ");
    claveIngresada = Console.ReadLine();

    if (claveCorrecta.Equals(claveIngresada) == false)
    {
        Console.WriteLine("ERROR: Contraseña incorrecta. ");
    }
}

Console.WriteLine($"Constraseña correcta: {claveCorrecta}");