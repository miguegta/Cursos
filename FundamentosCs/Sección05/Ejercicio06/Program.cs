//Programa que permita ingresar una vocal y nos devuelva una palabra que empiece con esa vocal.

//Crear variables
char vocal;
string palabra = "";

//Pedir info
Console.WriteLine($"Ingresa una vocal");
vocal = Convert.ToChar(Console.ReadLine());

//Evaluar
switch (char.ToUpper(vocal))
{
    case 'A':
        palabra = "Aceite";
        break;
    case 'E':
        palabra = "Elefante";
        break;
    case 'I':
        palabra = "Iglú";
        break;
    case 'O':
        palabra = "Oso";
        break;
    case 'U':
        palabra = "Universo";
        break;
}

if (string.IsNullOrEmpty(palabra))
{
    Console.WriteLine($"Ingrese una vocal correcta.");
}
else
{
    Console.WriteLine($"La palabra escogida es: {palabra}");
}






