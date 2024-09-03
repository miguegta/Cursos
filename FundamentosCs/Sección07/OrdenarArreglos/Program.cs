int[] numeros = { 5, 2, 6, 10, 9, 11, 15, 20 };

//Orden ascendente
Console.WriteLine("Ascendente");
Array.Sort(numeros);
foreach (int n in numeros)
{
    Console.WriteLine(n);
}

//Orden descendente
Console.WriteLine("\nDescendente");
Array.Sort(numeros, (x, y) => y.CompareTo(x));
foreach (int n in numeros)
{
    Console.WriteLine(n);
}

//2da forma de hacer orden descendente
Console.WriteLine("\nUsando Reverse");
Array.Sort(numeros);    //Forma ascendente
Array.Reverse(numeros);
foreach (int n in numeros)
{
    Console.WriteLine(n);
}
