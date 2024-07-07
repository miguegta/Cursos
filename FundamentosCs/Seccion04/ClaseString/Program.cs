string nombre = "Mario";

//Algunos metodos mas utilizados con string 
Console.WriteLine($"Mi nombre es {nombre}");
Console.WriteLine($"Mi nombre tiene {nombre.Length} letras.");
Console.WriteLine($"Mi nombre empieza con \"Ma\": {nombre.StartsWith("Ma")} ");
Console.WriteLine($"Mi nombre empieza con \"Ma\": {nombre.StartsWith("Ma", StringComparison.OrdinalIgnoreCase)}");
Console.WriteLine($"Mi nombre termina con \"io\": {nombre.EndsWith("io")}");
Console.WriteLine($"Mi nombre contiene la letra \"a\": {nombre.Contains("a")}");
Console.WriteLine($"La 1ra letra de mi nombre es : {nombre[0]}");
Console.WriteLine($"La 2da letra de mi nombre es : {nombre[1]}");
Console.WriteLine($"La 3ra letra de mi nombre es : {nombre[2]}");
Console.WriteLine($"La 4ta letra de mi nombre es : {nombre[3]}");
Console.WriteLine($"La 5ta letra de mi nombre es : {nombre[4]}");
Console.WriteLine($"La ultima letra de mi nombre es: {nombre[nombre.Length - 1]}");
Console.WriteLine($"La ultima letra de mi nombre es: {nombre[^1]}");

//Comparar
string n1 = "Gianny";
string n2 = "GIANNY";
Console.WriteLine($"{n1} es igual a {n2}: {n2.Equals(n1, StringComparison.OrdinalIgnoreCase)}");

//Substring
string frase = "Me gusta aprender a programar";
string nuevaFrase = frase.Substring(9);
string nuevaFrase2 = frase[9..];
Console.WriteLine(nuevaFrase);
Console.WriteLine(nuevaFrase2);

Console.WriteLine("-------------------");

string tomarIndexInicialFinal = frase.Substring(0, 17);
string tomarIndexInicialFinal2 = frase[..17];
Console.WriteLine(tomarIndexInicialFinal);
Console.WriteLine(tomarIndexInicialFinal2);