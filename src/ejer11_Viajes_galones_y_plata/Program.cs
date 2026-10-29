//Viajes galones y plata
//definir datos
double v, t, d;
double rendimiento, preciogalon, galonesnecesarios, costocombustible;
Console.WriteLine("calculo de viaje");

//velocidad y tiempo
Console.WriteLine("ingrese la velocidad (k/h): ");
v = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ingrese el tiempo de viaje (h): ");
t= Convert.ToDouble(Console.ReadLine());
//calcular distancia
d = v * t;
Console.WriteLine($"la distancia recorrida es: {d} km/n ");
Console.WriteLine("calculo de combustible");
//leer rendimiento y precio de galon
Console.WriteLine("ingrese el rendimiento de el vehiculo (k/galon):");
rendimiento=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ingrese el precio de cada galon: ");
preciogalon=Convert.ToDouble(Console.ReadLine());
if (rendimiento > 0) ;
galonesnecesarios = d / rendimiento;
costocombustible = galonesnecesarios * preciogalon;

Console.WriteLine("---------------------------------");
Console.WriteLine($"galones necesarios: ${galonesnecesarios}");
Console.WriteLine($"costo total del combustible: ${costocombustible}"); 
