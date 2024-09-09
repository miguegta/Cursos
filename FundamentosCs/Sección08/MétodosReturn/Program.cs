/*
void Suma()
{
    int s = 10 + 5;
    Console.WriteLine(s);
}

Suma();

int SumaReturn()
{
    return 10 + 5;  //15
}

int x = SumaReturn();
Console.WriteLine($"El valor es: {x}");
*/

//Ejercicio
Console.WriteLine("Ingresa el radio del circulo: ");
double radio = Convert.ToDouble(Console.ReadLine());

double CalcularArea(double pRadio)
{
    return Math.PI * Math.Pow(pRadio, 2);
}

double CalcularCircunferencia(double pRadio)
{
    double c = 2 * pRadio * Math.PI;
    return c;
}


double area = CalcularArea(radio);
double circ = CalcularCircunferencia(radio);

Console.WriteLine($"Area del circulo: {area:0.##}");
Console.WriteLine($"Circunferencia del circulo: {circ:0.##}");