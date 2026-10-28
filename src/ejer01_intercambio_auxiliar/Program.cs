//intercambio de valores
//definir datos
int a, b, c;
//ingresar datos
Console.Write("ingresa el valor de a: ");
a=Convert.ToInt32(Console.ReadLine());
Console.Write("ingresa el valor de b: ");
b=Convert.ToInt32(Console.ReadLine());

//procedimiento
c = a;
a= b;
b= c;
//resultado
console.Writeline($"los valores originales son {a} y {b}");
Console.WriteLine($"Los valores cambiados resultan como a: {a} y b: {b} ");
