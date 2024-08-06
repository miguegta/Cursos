/*
  var resultado = expresionSwitch switch
  {
       valor1 => resultado1,
       valor2 => resultado2,
       valor3 => resultado3,
       _=> resultadoPorDefecto
  };
 */

//Ejemplo 01

Console.WriteLine($"Selecciona un color:\n(1) Rojo\n(2) Verde\n(3) Azul");

string color = Console.ReadLine();
string des = "";
string description = color switch
{
    "Rojo" => "Es un color apasionado",
    "Verde" => "Es un color natural",
    "Azul" => "Es un color tranquilo",
    _=> "No es un color valido"
};

Console.WriteLine(description);