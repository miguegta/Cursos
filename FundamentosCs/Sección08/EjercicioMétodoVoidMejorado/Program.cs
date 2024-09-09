Console.WriteLine("Ingresa el 1er número:");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresa el 2do número:");
double n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresa la operación a realizar:\n1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir");
int operacion = Convert.ToInt32(Console.ReadLine());

void Calcular()
{
    double x = 0;
    switch (operacion)
    {
        case 1:     //Sumar
            x = n1 + n2;
            break;

        case 2:     //Restar
            x = n1 - n2;
            break;

        case 3:     //Multiplicar
            x = n1 * n2;
            break;

        case 4:     //Dividir
            x = n1 / n2;
            break;
    }

    Console.WriteLine($"El resultado de la operación es: {x}");
}

void CalcularOtraForma()
{
    double x = operacion switch
    {
        1 => n1 + n2,
        2 => n1 - n2,
        3 => n1 * n2,
        4 => n1 / n2,
    };

    Console.WriteLine($"El resultado de la operación es: {x}");
}

CalcularOtraForma();
Calcular();
