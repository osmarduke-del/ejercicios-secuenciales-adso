//interes compuesto
//definir variables
double ci, cf, m, int_m, int_g;
//pedir datos
Console.WriteLine("ingrese la capital inicial");
ci=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ingrese la cantidad de interes mensual (%)");
int_m=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ingrese el numero de meses");
m=Convert.ToInt32(Console.ReadLine());
//procedimiento

cf = ci * Math.Pow((1 + int_m / 100), m);
int_g = cf - ci;
//imprimir resultados
Console.WriteLine($"capital final: {cf}");
Console.WriteLine($"interes ganados: {int_g}");
