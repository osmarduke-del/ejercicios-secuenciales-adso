//hipotenusa con pitagoras
//definir variables
double cateto1, cateto2, hipotenusa;
Console.WriteLine("Ingrese el valor del primer cateto: ");
cateto1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el valor del segundo cateto: ");
cateto2 = Convert.ToDouble(Console.ReadLine());
//calcular hipotenusa
hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
//mostrar resultado
Console.WriteLine("La hipotenusa es: " + hipotenusa);
