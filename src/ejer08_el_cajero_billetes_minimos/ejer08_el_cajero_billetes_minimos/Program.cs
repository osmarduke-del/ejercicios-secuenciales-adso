//el cajero de billetes minimos
//definir valores
int monto, billetes50000, billetes20000, billetes10000, billetes5000, resto;
Console.WriteLine("Ingrese el monto a retirar (multiplo de 5000):");
monto = int.Parse(Console.ReadLine());
billetes50000 = monto / 50000;
resto = monto % 50000;
billetes20000 = resto / 20000;
resto = resto % 20000;
billetes10000 = resto / 10000;
resto = resto % 10000;
billetes5000 = resto / 5000;
resto = resto % 5000;
Console.WriteLine("Billetes de 50000: " + billetes50000);
Console.WriteLine("Billetes de 20000: " + billetes20000);
Console.WriteLine("Billetes de 10000: " + billetes10000);
Console.WriteLine("Billetes de 5000: " + billetes5000);
Console.WriteLine("Resto: " + resto);
