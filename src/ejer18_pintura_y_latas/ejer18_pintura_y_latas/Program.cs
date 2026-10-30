//pinturas y latas
//definir variables para ver cuantas latas se usan  y cuantos litros quedan sueltos
double litros, litrosPorLata, latas, litrosRestantes,rendimiento,metroscuadradosapintar;
//definir variables para ver cuantas latas se usan  y cuantos litros quedan sueltos
Console.WriteLine("Ingrese la cantidad de metros cuadrados a pintar: ");
metroscuadradosapintar = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el rendimiento de la pintura (metros cuadrados por litro): ");
rendimiento = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de litros por lata: ");
litrosPorLata = Convert.ToDouble(Console.ReadLine());
//calcular cuantos litros se necesitan para pintar los metros cuadrados
litros = metroscuadradosapintar / rendimiento;
latas = Math.Ceiling(litros / litrosPorLata);
//calcular cuantos litros quedan sueltos
litrosRestantes = (latas * litrosPorLata) - litros;
//mostrar resultados
Console.WriteLine("Se necesitan " + latas + " latas de pintura.");
Console.WriteLine("Quedarán " + litrosRestantes + " litros de pintura sobrantes.");

