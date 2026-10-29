//de el segundo a la hora  
//definir variables
double segundos,horas,minutos;
//pedir al usuario que ingrese los segundos
Console.WriteLine("Ingrese los segundos: ");
segundos = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Las horas, minutos y segundos son: " + (segundos / 3600) + " horas, " + (segundos / 60) + " minutos y " + (segundos % 60) + " segundos.");


