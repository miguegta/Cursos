Console.WriteLine("En que día se encuentra: ");

string respuesta = Console.ReadLine();

//Lunes a Viernes -> Trabajar      Sabado a Domingo -> Descansar
switch (respuesta)
{
    case "Lunes":
    case "Martes":
    case "Miercoles":
    case "Jueves":
    case "Viernes":
        Console.WriteLine("Debes Trabajar");
        break;

    case "Sabado":
    case "Domingo":
        Console.WriteLine("Debes Descansar");
        break;

    default:
        break;
}