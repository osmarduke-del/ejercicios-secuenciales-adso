//promedio de notas
//datos
double nota1, nota2, nota3, promedio;
//dar datos
Console.WriteLine("poner datos que desea calcular");
Console.WriteLine("introducir nota 1: ");
nota1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("introducir nota 2: ");
nota2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("introducir nota 3: ");
nota3=Convert.ToInt32(Console.ReadLine());

//operacion

promedio = (nota1 * 0.25)+(nota2 * 0.35)+(nota3 * 0.4);
Console.WriteLine("el promedio es: "+promedio);

