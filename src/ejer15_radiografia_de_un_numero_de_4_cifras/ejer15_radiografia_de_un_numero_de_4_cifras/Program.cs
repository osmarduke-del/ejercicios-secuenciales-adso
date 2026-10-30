//radiografia de un numero de 4 cifras
//definir variables
int numero, cifra1, cifra2, cifra3, cifra4;
Console.WriteLine("Ingrese un numero de 4 cifras");
numero = int.Parse(Console.ReadLine());
cifra1 = numero / 1000;
cifra2 = (numero % 1000) / 100;
cifra3 = (numero % 100) / 10;
cifra4 = numero % 10;
Console.WriteLine("La radiografia del numero es: {0} {1} {2} {3}", cifra1, cifra2, cifra3, cifra4);
