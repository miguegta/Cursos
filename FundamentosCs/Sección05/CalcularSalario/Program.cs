/*
 * Calcular el salario final de un empleado según su salario base y 
 * un porcentaje del presupuesto según el rol al cual pertenece en la empresa.
 * Salarios:
 * Empleado-> $30,000
 * Supervisor-> $50,000
 * Gerente-> $80,000
 * Si el presupuesto es inferior a $125,000 entonces el factor es 80%
 * Si el presupuesto está entre $125,000 y $175,000 entonces el factor es 100%
 * Si el presupuesto es  superior a $175,000 entonce el factor es 120%
 */

double salarioBase = 0;
double presupuesto = 0;

Console.WriteLine("Ingrese su rol:\n1. Empleado\n2. Supervisor\n3. Gerente");
string rol = Console.ReadLine();

Console.WriteLine("Ingresa el presupuesto: ");
presupuesto = Convert.ToDouble(Console.ReadLine());

switch (rol)
{
    case "Empleado":
        salarioBase = 30_000;
        break;

    case "Supervisor":
        salarioBase = 50_000;
        break;

    case "Gerente":
        salarioBase = 80_000;
        break;

    default:
        salarioBase = 0;
        break;
}

//Usando expresion switch
salarioBase = rol switch
{
    "Empleado" => 30_000,
    "Supervisor" => 50_000,
    "Gerente" => 80_000,
};

//Calcular factor
double factor = presupuesto switch
{
    < 125_000 => 0.8,
    >= 125_000 and < 175_000 => 1.0,
    >= 175_000 => 1.2
};

double salarioFinal = salarioBase * factor;

Console.WriteLine($"El rol del empleado: {rol}");
Console.WriteLine($"El salario base es: {salarioBase}");
Console.WriteLine($"El factor es : {factor}");
Console.WriteLine($"El salario final es: {salarioFinal}");