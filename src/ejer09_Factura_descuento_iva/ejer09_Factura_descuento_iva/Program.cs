//definir variables
double precio, descuento, subtotal, iva, total;

Console.WriteLine("Ingrese el precio del producto: ");
precio = Convert.ToDouble(Console.ReadLine());

//calcular descuento
descuento = precio * 0.10; //descuento del 10%

//calcular subtotal con descuento 
subtotal = precio - descuento;

//calcular iva 
iva = subtotal * 0.19; //iva del 19%

//calcular total final
total = subtotal + iva;

//mostrar resultados
Console.WriteLine("Precio original del producto: {0}", precio);
Console.WriteLine("Descuento (10%): {0}", descuento);
Console.WriteLine("Precio con descuento: {0}", subtotal);
Console.WriteLine("IVA (19% sobre subtotal): {0}", iva);
Console.WriteLine("Total final: {0}", total);
