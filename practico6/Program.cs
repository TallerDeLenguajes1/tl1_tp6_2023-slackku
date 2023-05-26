Console.Write("|--------------------------------------------------|\n");
Console.Write("|                  CALCULADORA V2                  |\n");
Console.Write("|--------------------------------------------------|\n");
Console.Write("Ingrese un numero: ");
string? input = Console.ReadLine();
if (Single.TryParse(input, out float n1))
{
    float numero = Single.Parse(input);
    Console.WriteLine("El valor absoluto de " + numero + ": " + Single.Abs(numero));
    Console.WriteLine("El cuadrado de " + numero + ": " + numero * numero);
    if (numero > 0)
    {
        Console.WriteLine("La raiz cuadrada de " + numero + ": " + Single.Sqrt(numero));
    }
    else
    {
        Console.WriteLine("La raiz cuadrada del numero ingresado no es un numero real");
    }
    Console.WriteLine("El seno de " + numero + ": " + Single.Sin(numero));
    Console.WriteLine("El coseno de " + numero + ": " + Single.Cos(numero));
    var numString = numero.ToString();
    string[] arrNumString = numString.Split(',');
    Console.WriteLine("La parte entera de " + numero + ": " + arrNumString[0]);

    Console.Write("Ingrese otro numero: ");
    string? secondInput = Console.ReadLine();
    if (Single.TryParse(secondInput, out float n2))
    {
        float num1 = Single.Parse(secondInput);
        Console.Write("Ingrese otro numero: ");
        string? thirdInput = Console.ReadLine();
        if (Single.TryParse(thirdInput, out float n3))
        {
            float num2 = Single.Parse(thirdInput);
            if (num1 > num2)
            {
                Console.WriteLine("El maximo entre " + num1 + " y " + num2 + " es " + num1);
                Console.WriteLine("El minimo entre " + num1 + " y " + num2 + " es " + num2);
            }
            else
            {
                Console.WriteLine("El maximo entre " + num1 + " y " + num2 + " es " + num2);
                Console.WriteLine("El minimo entre " + num1 + " y " + num2 + " es " + num1);
            }



        }
        else
        {
            Console.WriteLine("No ha ingresado un numero.");
        }
    }
    else
    {
        Console.WriteLine("No ha ingresado un numero.");
    }


}
else
{
    Console.WriteLine("No ha ingresado un numero.");
}