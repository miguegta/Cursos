/*
  Cree un programa que permita ingresar una edad y te diga qué tipo de persona eres.
  Validar que la edad sea mayor o igual a 0.
  De 0 a 3 años, recién nacido.
  De 4 a 9 años, infante.
  De 10 a 12 años, puberto.
  De 13 a 19 años, adolescente.
  De 20 a 29 años, joven.
  De 30 a 49 años, adulto.
  De 50 a 59 años, adulto mayor.
  De 60 a más, anciano.
*/

using System.Diagnostics;

int edad = 0;
string mensaje = "";

Console.WriteLine($"Ingresa tu edad: ");
edad = Convert.ToInt32(Console.ReadLine());

switch (edad)
{
    case >= 60:
        mensaje = "Anciano";
        break;

    case >= 50:
        mensaje = "Adulto mayor";
        break;

    case >= 30:
        mensaje = "Adulto";
        break;

    case >= 20:
        mensaje = "Joven";
        break;

    case >= 13:
        mensaje = "Adolescente";
        break;

    case >= 10:
        mensaje = "Puberto";
        break;

    case >= 4:
        mensaje = "Infante";
        break;

    case >= 0:
        mensaje = "Recién nacido";
        break;

    default:
        mensaje = "Ingrese una edad correcta";
        break;
}

Console.WriteLine($"{mensaje}");