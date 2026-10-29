//termometro triple °C °F °K
//definir variables
double c, f, k;
Console.WriteLine("Ingrese la temperatura en °C: ");
c= Convert.ToDouble(Console.ReadLine());

//operaciones
f = (c * 9 / 5) + 32;
k = c + 273.15;
//imprimir resultados
Console.WriteLine("el resultado en °F es: " + f);
Console.WriteLine("el resultado en °K es: " + k);


