/*
  var resultado = expresionSwitch switch
  {
       valor1 => resultado1,
       valor2 => resultado2,
       valor3 => resultado3,
       _=> resultadoPorDefecto
  };
 */

string texto = "Me gusta programar en C#.";
string resultado = texto switch
{
    string s when s.Length > 10 => "Texto muy largo",
    string s when s.Length > 5 => "Texto largo",
    string m when m.Length > 0 => "Texto corto",
    _=> "Texto vacio"
};
Console.WriteLine(resultado);