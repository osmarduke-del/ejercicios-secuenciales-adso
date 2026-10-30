//negocio o perdida
//definir variables
double costodefabricacion,precioventa,unidades,gananciatotal,rentabiliad;
//solicitar datos al usuario
Console.WriteLine("Ingrese el costo de fabricación del producto: ");
costodefabricacion= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el precio de venta del producto: ");
precioventa= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el número de unidades: ");
unidades= Convert.ToDouble(Console.ReadLine());
//calcular ganancia total
gananciatotal = (precioventa - costodefabricacion) * unidades;
//calcular rentabilidad
rentabiliad = (gananciatotal / (costodefabricacion * unidades)) * 100;
//mostrar resultados
Console.WriteLine("La ganancia total es: " + gananciatotal);
