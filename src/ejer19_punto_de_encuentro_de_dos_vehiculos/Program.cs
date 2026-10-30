//punto de encuentro de dos vehiculos
//definir variables
double d, v1, v2, t, dr,vh1,vh2;
//pedimos datos al usuario
Console.WriteLine("ingrese distancia inicial en metros");
d =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese la velocidad de el vehiculo 1");
v1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese la velocidad de el vehiculo 2");
v2 = Convert.ToInt32(Console.ReadLine());
//operacion
t = d / v1 * v2;
vh1 = v1 * t;
vh2= v2 * t;
dr = (vh1 + vh2);
//imprimimos 
Console.WriteLine($"el tiempo hasta el encuentro es: {t} minutos");
Console.WriteLine($"la distancia recorrida es:  {dr} metros");