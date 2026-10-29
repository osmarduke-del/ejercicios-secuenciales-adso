//El rectangulo que crece
//validar datos
double b, a,area,p ;
Console.WriteLine("Ingrese la base del rectangulo");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del rectangulo");
a = double.Parse(Console.ReadLine());
b = b * 2;
a = a * 3;
area = b * a;
p = 2 * (b + a);
Console.WriteLine("El area del rectangulo es: {0}", area);
Console.WriteLine("El perimetro del rectangulo es: {0}", p);
