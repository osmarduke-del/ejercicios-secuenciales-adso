//calcular la suma de 3 digitos 
//definir variables
int num1,num2,num3,suma,numero;
Console.WriteLine("introducir el numero de 3 digitos");
numero=Convert.ToInt32(Console.ReadLine());
{
    num3 = numero % 10;
    num2 = (numero / 10) % 10;
    num1 = numero / 100;
}
//calcular la suma
suma= num3 + num2 + num1;
//imprimimos
Console.WriteLine("la suma de los 3 digitos es: " + suma);



