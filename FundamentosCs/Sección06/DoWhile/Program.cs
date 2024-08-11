/*
  Cree un programa que calcule el peso ideal 
  de una persona según su genero
 */

string genero = "";
double peso = 0;
double altura = 0;

do
{
    Console.WriteLine("Introduce tu genero:\n1. M = Masculino\n2. F = Femenino ");
    genero = Console.ReadLine();

} while (genero.Equals("m", StringComparison.OrdinalIgnoreCase)
&& genero.Equals("f", StringComparison.OrdinalIgnoreCase));

Console.WriteLine("Introduce tu altura: ");
altura = Convert.ToDouble(Console.ReadLine());

if (genero.Equals("m", StringComparison.OrdinalIgnoreCase))
{
    peso = altura - 110;
}
else
{
    peso = altura - 120;
}

Console.WriteLine($"Tu genero es : {genero}");
Console.WriteLine($"Tu altura es : {altura}");
Console.WriteLine($"Tu peso ideal es : {peso} kilos.");





