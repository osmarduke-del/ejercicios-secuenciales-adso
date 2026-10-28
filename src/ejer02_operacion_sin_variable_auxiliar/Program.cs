//operacion sin variable auxiliar
//datos
int a, b;
//ingreso de valores
Console.Write("ingrese el valor a: ");
a=Convert.ToInt32(Console.ReadLine());
Console.Write("ingrese el valor b: ");
b=Convert.ToInt32(Console.ReadLine());

//operacion
a = a + b;
b = a - b;
a = a - b;
//imprimo resultado
Console.Write($"el cambio de valores da: a: {a} y b: {b} ");


