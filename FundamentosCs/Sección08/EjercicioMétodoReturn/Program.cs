Console.WriteLine("Ingresa un texto:");
string texto = Console.ReadLine();

// Caracteres
int ContarCaracteres(string pTexto)
{
    return pTexto.Length;
}

// Palabras
int ContarPalabras(string pTexto)
{
    //Me gusta programar
    string[] palabras = pTexto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    Console.WriteLine("Palabras encontradas: ");
    foreach (var p in palabras)
    {
        Console.WriteLine(p);
    }
    return palabras.Length;
}

int nCaracteres = ContarCaracteres(texto);
int nPalabras = ContarPalabras(texto);

Console.WriteLine($"Cantidad de caracteres {nCaracteres}");
Console.WriteLine($"Cantidad de palabras {nPalabras}");

