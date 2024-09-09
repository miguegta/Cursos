/*
  Calcular el subTotal y Total de una compra
  de n articulos.
  Considerar impuesto y descuento.
 */

Console.WriteLine("Ingresar cantidad de articulos");
int cantidad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresar precio unitario:");
double precioUnitario = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresar descuento:");
double descuentoPrecio = Convert.ToInt32(Console.ReadLine());

double subTotal = 0;
double total = 0;

void CalcularSubtotal(int pCantidad, double precio)
{
    subTotal = pCantidad * precio;
}

void CalcularTotal(double pSubTotal, double impuesto = 0.16, double pDescuento = 0)
{
     total = pSubTotal + (pSubTotal * impuesto) - pDescuento;
}

CalcularSubtotal(cantidad, precioUnitario);

if (descuentoPrecio > 0)
{
    //CalcularTotal(subTotal, 0.16, descuentoPrecio);
    CalcularTotal(subTotal, pDescuento: descuentoPrecio);
}
else
{
    CalcularTotal(subTotal, 0.20);
}


Console.WriteLine($"Subtotal: {subTotal}");
Console.WriteLine($"Total: {total}");