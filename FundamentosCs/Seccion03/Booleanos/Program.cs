// true
//false

//Creación de tipo bool
bool hoyEsViernes = false;
bool abierto = true;
Console.WriteLine(hoyEsViernes);
Console.WriteLine(abierto);

Console.WriteLine("-------------------------");

//Comparación números
int n1 = 10;
int n2 = 20;
bool esMayor = n1 > n2;
Console.WriteLine(esMayor); //False
Console.WriteLine(n1 < n2); //True

Console.WriteLine("-------------------------");

// Trabajar con string
string s1 = "Motos";
string s2 = "Motos";
Console.WriteLine(s1 == s2);    //Primera forma
Console.WriteLine(s1.Equals(s2));   //Segunda forma
Console.WriteLine(string.Equals(s1, s2));   //Tercera forma

