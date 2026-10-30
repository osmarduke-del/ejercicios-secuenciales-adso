//espejo de tres valores
//definir valores
int num1, num2, num3, numero, inverso= 0;
Console.WriteLine("ingrese el numero de 3 cifras que desea invertir");
numero =Convert.ToInt32(Console.ReadLine());

//operacion
num3 = numero % 10;
num2 = (numero / 10) % 10;
num1 = numero / 100;

numero = num3 + num2 + num1;
inverso = (inverso * 10) + numero;
//imprimimpos
Console.WriteLine($"el resultado es: {inverso} ");
