//Programa que indica si puedo asistir a un concierto

bool boletoComprado = false;
bool podemosAsistir = false;

Console.WriteLine($"Compraste el boleto?");
string respuestaBoleto = Console.ReadLine();

if (respuestaBoleto.Equals("Si", StringComparison.OrdinalIgnoreCase))
{
    boletoComprado = true;
}

Console.WriteLine("Puedes asistir mañana al concierto?");
string respuestaAsistir = Console.ReadLine();
if (respuestaAsistir.Equals("Si", StringComparison.OrdinalIgnoreCase))
{
    podemosAsistir = true;
}

if (boletoComprado && podemosAsistir)
{
    Console.WriteLine($"Podemos asistir al concierto!!");
}
else
{
    Console.WriteLine($"No podemos asistir al concierto.");
}