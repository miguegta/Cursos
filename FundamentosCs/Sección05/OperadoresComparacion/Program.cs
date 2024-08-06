/*
== Igualdad
> Mayor que 
< Menor que
>= Mayor o igual 
<= Menor o igual
!= Diferente
 */

Console.WriteLine("Ingresa tu sueldo: ");
int sueldo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa el sueldo de tu mejor amigo: ");
int sueldoAmigo = Convert.ToInt32(Console.ReadLine());

if (sueldo == sueldoAmigo)
{
    Console.WriteLine($"Mi mejor amigo y yo ganamos el mismo sueldo.");
}
if (sueldo > sueldoAmigo)
{
    Console.WriteLine("Gano más que mi mejor amigo.");
}
if (sueldo < sueldoAmigo)
{
    Console.WriteLine("Gano menos que mi mejor amigo.");
}
if (sueldo >= sueldoAmigo)
{
    Console.WriteLine($"Mi sueldo es mayor o igual que el de mi amigo.");
}
if (sueldo <= sueldoAmigo)
{
    Console.WriteLine($"Mi sueldo es menor o igual que el de mi amigo. ");
}
if (sueldo != sueldoAmigo)
{
    Console.WriteLine($"Mi sueldo es diferente al de mi amigo.");
}

bool haceFrio = false;
haceFrio = true;
haceFrio = !haceFrio;
