/*
  Tienes una tienda en línea que vende productos electrónicos.
  La tienda tiene una política de descuentos para los clientes  
  basada en el monto total de la compra:
  Si el monto total es menor a $50, no hay descuento.
  Si el monto total es entre $50 y $100, el descuento es del 5%.
  Si el monto total es entre $100 y $200, el descuento es del 10%.
  Si el monto total es mayor a $200, el descuento es del 15%.
  
  Además, si el cliente tiene una membresía premium,
  se aplicará un descuento adicional del 15% en todos los casos.
*/

decimal totalCompra = 0;
decimal descuento = 0;
bool esPremium = false;

Console.WriteLine("Ingrese el total de su compra: ");
totalCompra = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("¿Eres un cliente premium?");
string respuesta = Console.ReadLine(); //Si - No

if (respuesta.Equals("Si", StringComparison.OrdinalIgnoreCase)) //SI si
{
    esPremium = true;
}

//Usando if 

if (totalCompra < 50)
{
    descuento = 0; // 0%
}
else if (totalCompra >= 50 && totalCompra < 100)
{
    descuento = 0.05M; // 5% 
}
else if (totalCompra >= 100 && totalCompra < 200)
{
    descuento = 0.10M; // 10%
}
else if (totalCompra > 200)
{
    descuento = 0.15M; // 15%
}


//Usando Expresion Switch
descuento = totalCompra switch
{
    < 50 => 0,
    >= 50 and < 100 => 0.05m,
    >= 100 and < 200 => 0.10m,
    >= 200 => 0.15m
};


if (esPremium)
{
    descuento += 0.15M;
}

decimal totalConDescuento = totalCompra - (totalCompra * descuento);

Console.WriteLine($"El total de compra: {totalCompra}");
Console.WriteLine($"Descuento: {descuento}");
Console.WriteLine($"El total con descuento: {totalConDescuento}");

