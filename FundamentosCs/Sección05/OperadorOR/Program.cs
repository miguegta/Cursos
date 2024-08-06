/*
    || - OR - O
     A   B   |  R 
     F   F   =  F   
     F   V   =  V
     V   F   =  V
     V   V   =  V

    True si al menos UNO es verdadero 
    if (condición1 || condición2)
*/

//Progama que nos indica si podemos acceder a una beca universitaria
//Extra: Solo si tu promedio > 18 o Deportista calificado

double promedio;
string deportista;

Console.WriteLine($"Ingresa promedio ponderado: ");
promedio = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"¿Eres deportista calificado?");
deportista = Console.ReadLine();

if (promedio >= 18 || deportista.Equals("Si", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine($"Si puedes acceder a la beca universitaria.");
}
else
{
    Console.WriteLine($"No cumples con los requisitos");
}
