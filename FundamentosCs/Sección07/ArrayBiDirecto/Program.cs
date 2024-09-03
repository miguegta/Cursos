//Creación directa arreglo bidimensional
string[,] nombres = new string[2, 3]
{
    { "Julia", "Maria", "Rosa" },
    { "Andres", "Ramon", "Mariano" }
};

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{nombres[i,j]}\t");
    }

    Console.WriteLine();
}