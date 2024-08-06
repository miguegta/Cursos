//Ingresar un número y clasificarlo

Console.WriteLine("Ingrese un número");

int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case int n when n < 0:
        Console.WriteLine("El número es negativo.");
        break;

    case int n when n == 0:
        Console.WriteLine("El número es 0.");
        break;

    case int n when n > 0 && n < 10:
        Console.WriteLine("El número es pequeño.");
        break;

    case int n when n >= 10 && n < 100:
        Console.WriteLine("El número es mediano");
        break;

    case int n when n >= 100:
        Console.WriteLine("El número es grande.");
        break;

    default:
        Console.WriteLine("El número ingresado no es valido.");
        break;



}