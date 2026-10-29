//voltear un numero de dos cifras
//datos
int numero,invert;

Console.WriteLine("ingrese un numero de dos digitos");
numero = Convert.ToInt32(Console.ReadLine());
{
    invert = numero % 10;
    numero /= 10;
    invert = (invert * 10) + numero;
}
//imprimimos
Console.WriteLine($"el numero invertido es: {invert}");

