//Ejercio 1
//Crear variables
double alquilerEspacioFeria;
double publicidad;
double transporte ;
double serviciosFeriales;
double decoracion ;
double gastosVarios;

Console.WriteLine("Ejercicio 1");
Console.WriteLine("Ingrese el Capital a invertir");
double capitalParaInvertir = Convert.ToDouble(Console.ReadLine());

alquilerEspacioFeria = capitalParaInvertir *  0.23;
publicidad = capitalParaInvertir * 0.07;
transporte = capitalParaInvertir * 0.26;
serviciosFeriales = capitalParaInvertir * 0.12;
decoracion = capitalParaInvertir * 0.21;
gastosVarios = capitalParaInvertir * 0.11;

Console.WriteLine($"El monto total a invertir por cada rubro en alquiler de espacio en la feria es: {alquilerEspacioFeria:C}");
Console.WriteLine($"El monto total a invertir por cada rubro en publicidad es: {publicidad:C}");
Console.WriteLine($"El monto total a invertir por cada rubro en transporte es: {transporte:C}");
Console.WriteLine($"El monto total a invertir por cada rubro en servicios feriales es: {serviciosFeriales:C}");
Console.WriteLine($"El monto total a invertir por cada rubro en decoracion es: {decoracion:C}");
Console.WriteLine($"El monto total a invertir por cada rubro en gastos Varios es: {gastosVarios:C}");

//Ejecicio 2
//Crear variables
double tamara;
double josue ;
double caleb;
double daniel;
double david;

Console.WriteLine("Ejercicio 2");
Console.WriteLine("Ingrese la cantidad a repartir: ");
double dineroRepartido = Convert.ToDouble(Console.ReadLine());

josue = 0.27 * dineroRepartido;
tamara = 0.85 * josue;
daniel = 0.25 * dineroRepartido;
caleb = 0.23 * (josue + daniel);
david = dineroRepartido - (josue + tamara + daniel + caleb);

Console.WriteLine($"La cantidad total de Tamara es: {tamara:C}");
Console.WriteLine($"La cantidad total de Josué es: {josue:C}");
Console.WriteLine($"La cantidad total de Caleb es: {caleb:C}");
Console.WriteLine($"La cantidad total de Daniel es: {daniel:C}");
Console.WriteLine($"La cantidad total de David es: {david:C}");


//Ejercicio 3
//Crear varibles
double avLaMAr;
double av28DeJulio;
double avBolivar;
double avClement;
double avSucre;

Console.WriteLine("Ejercicio 3");
Console.WriteLine("Ingrese cantidad invertida en la reparación de las avenidas");
double cantidadRepartida = Convert.ToDouble(Console.ReadLine());

av28DeJulio = 0.25 * cantidadRepartida;
avClement = 0.15 * cantidadRepartida;
avBolivar = 0.10 * (av28DeJulio + avClement);
avLaMAr = 0.35 * avBolivar;
avSucre = cantidadRepartida - (av28DeJulio + avLaMAr + avClement + avBolivar);

Console.WriteLine($"La  cantidad total para la Av.La Mar es: {avLaMAr:C}");
Console.WriteLine($"La cantidad total para la Av. 28 de Julio es: {av28DeJulio:C}");
Console.WriteLine($"La cantidad total para la Av. Bolivar es: {avBolivar:C}");
Console.WriteLine($"La cantidad total para la Av. Clemente es: {avClement:C}");
Console.WriteLine($"La cantidad total para la Av. Sucre es: {avSucre:C}");