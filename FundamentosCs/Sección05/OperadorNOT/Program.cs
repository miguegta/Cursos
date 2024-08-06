/*
    ! - NOT - No
      A | B 
      F | V 
      F | F     
    
    TRUE si el valor es False
    False is el valor es True
*/

//Ejercio: Veficar Edad 

int edad = 0;

Console.WriteLine($"Ingrese su edad: ");
edad = Convert.ToInt32(Console.ReadLine());

if (!(edad >= 18))
{
    Console.WriteLine($"No somos mayores de edad.");
}
else
{
    Console.WriteLine($"Si somos mayores de edad.");
}

//Como usar el valor false en if
bool tengoHambre = true;
if (tengoHambre == false)
{
    Console.WriteLine();
}
if (!tengoHambre)
{
    Console.WriteLine();
}