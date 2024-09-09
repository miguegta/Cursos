// Implementar método recursivo
// Imprimir del 10 al 1 de forma descendente

void ImprimirNumero(int x)
{
    if (x > 0)
    {
        Console.WriteLine(x);
        ImprimirNumero(x - 1);
    }
}

ImprimirNumero(10);