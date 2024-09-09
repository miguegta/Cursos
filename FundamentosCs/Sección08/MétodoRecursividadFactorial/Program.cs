Console.WriteLine("Ingresa un numero: ");
int numero = Convert.ToInt32(Console.ReadLine());

double CalcularFactorial(int pNumero)
{
    // 5! => 5*4*3*2*1 = 120
    // 0! => 1
    if (pNumero == 0)
    {
        return 1;
    }
    else
    {
        double x = pNumero * CalcularFactorial(pNumero - 1);
        return x;
    }
}

double factorial = CalcularFactorial(numero);
Console.WriteLine($"El factorial de {numero} es: {factorial}");

