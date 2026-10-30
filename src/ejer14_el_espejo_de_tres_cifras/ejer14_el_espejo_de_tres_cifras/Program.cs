//el espejo de tres cifras inverso de un numero de tres cifras es el numero que se obtiene al invertir el orden de sus cifras. Por ejemplo, el espejo inverso de 123 es 321.
//definirvariable de tipo entero para almacenar el numero de tres cifras
int numero,num1,num2,num3, espejo;
Console.WriteLine("Ingrese un numero de tres cifras: ");
numero = Convert.ToInt32(Console.ReadLine());
//obtener las cifras del numero
num1 = numero / 100; //obtenemos la primera cifra
num2 = (numero / 10) % 10; //obtenemos la segunda cifra
num3 = numero % 10; //obtenemos la tercera cifra
 espejo = num3 * 100 + num2 * 10 + num1; //invertimos el orden de las cifras
Console.WriteLine("El espejo inverso de {0} es {1}", numero, espejo);
