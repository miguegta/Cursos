//Fecha y hora
DateTime ahora = DateTime.Now;
Console.WriteLine(ahora);

//Fecha actual
DateTime hoy = DateTime.Today;
Console.WriteLine(hoy);

//Obtener componentes por separado
DateTime fecha = DateTime.Now;
int año = fecha.Year;
Console.WriteLine($"El año es {año}");
int mes = fecha.Month;
Console.WriteLine($"El mes es {mes}");
int dia = fecha.Day;
Console.WriteLine($"El dia es {dia}");
int hora = fecha.Hour;
Console.WriteLine($"la hora es {hora}");
int minuto = fecha.Minute;
Console.WriteLine($"El minuto es {minuto}");
int segundo = fecha.Second;
Console.WriteLine($"El segundo es {segundo}");
Console.WriteLine("--------------------------");

//Manipular componentes
DateTime hoy2 = DateTime.Today;
Console.WriteLine($"Hoy es {hoy2}");
DateTime mañana = hoy2.AddDays(1);
Console.WriteLine($"mañana es {mañana}");
DateTime proxmes = hoy2.AddMonths(1);
Console.WriteLine($"El prox mes es {proxmes}");
DateTime proxaño = hoy2.AddYears(1);
Console.WriteLine($"El prox año es {proxaño}");
