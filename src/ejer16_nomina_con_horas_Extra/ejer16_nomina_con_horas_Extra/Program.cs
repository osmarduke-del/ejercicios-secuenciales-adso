//nomina con horas extra
//definir variables
double horasTrabajadas, horasExtra, pagoPorHora, pagoTotal, pagoHorasExtra;

Console.WriteLine("Ingrese el número de horas trabajadas: ");
horasTrabajadas = Convert.ToDouble(Console.ReadLine());
//definir el pago por hora
Console.WriteLine("Ingrese las horas extra trabajadas: ");
horasExtra = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el pago por hora: ");
pagoPorHora = Convert.ToDouble(Console.ReadLine());
//calcular horas extra
if (horasTrabajadas > 160)
{
    horasExtra = horasTrabajadas - 160;
    pagoHorasExtra = horasExtra * pagoPorHora * 1.25; //pago de horas extra
    pagoTotal = (160 * pagoPorHora) + pagoHorasExtra; //pago total
}
else
{
    horasExtra = 0;
    pagoHorasExtra = 0;
    pagoTotal = horasTrabajadas * pagoPorHora; //pago total
}
//mostrar resultados
Console.WriteLine("Horas trabajadas: " + horasTrabajadas);
Console.WriteLine("Horas extra: " + horasExtra);
Console.WriteLine("Pago por hora: " + pagoPorHora);
Console.WriteLine("Pago por horas extra: " + pagoHorasExtra);
Console.WriteLine("Pago total: " + pagoTotal);
