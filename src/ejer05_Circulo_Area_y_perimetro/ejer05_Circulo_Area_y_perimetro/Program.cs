//circulo area y perimetro
//definir variables
double radio, area, perimetro;
//operaciones
Console.WriteLine("ingrese el radio del circulo");
radio = Convert.ToDouble(Console.ReadLine());
area = Math.PI * radio * radio;
perimetro = 2 * Math.PI * radio;
Console.WriteLine("el area del circulo es: " + area);
Console.WriteLine("el perimetro del circulo es: " + perimetro);
