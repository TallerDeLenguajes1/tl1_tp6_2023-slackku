Console.Write("|--------------------------------------------------|\n");
Console.Write("|               CALCULADORA V1 & V2                |\n");
Console.Write("|--------------------------------------------------|\n");
Console.Write(" Suma: 1, Resta: 2, Multiplicacion: 3, Division: 4, Informacion: 5\n");
Console.Write(" Ingrese cual operacion desea realizar: ");
string? option = Console.ReadLine();
Console.Write("--------------------\n");
if (Single.TryParse(option, out float opt))
{
    float numero = Single.Parse(option);
    if (numero > 0 && numero < 5)
    {
        Console.Write("Ingrese el primer numero: ");
        string? inp1 = Console.ReadLine();
        Console.Write("Ingrese el segundo numero: ");
        string? inp2 = Console.ReadLine();
        if (Single.TryParse(inp1, out float i1) && Single.TryParse(inp2, out float i2))
        {
            showResult mostrador = new showResult();
            float num1 = Single.Parse(inp1);
            float num2 = Single.Parse(inp2);
            float res = 0;
            switch (numero)
            {
                case 1:
                    res = num1 + num2;
                    mostrador.mostrar(res);
                    break;

                case 2:
                    res = num1 - num2;
                    mostrador.mostrar(res);
                    break;
                case 3:
                    res = num1 * num2;
                    mostrador.mostrar(res);
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: No se puede realizar division por cero.");
                    }
                    else
                    {
                        res = num1 / num2;
                        mostrador.mostrar(res);
                    }
                    break;
            }
        }
    }
    else
    {
        if (numero == 5)
        {
            Console.Write("Ingrese un numero: ");
            string? infInp = Console.ReadLine();
            if (Single.TryParse(infInp, out float i3))
            {
                float numInfo = Single.Parse(infInp);
                Console.WriteLine("El valor absoluto de " + numInfo + ": " + Single.Abs(numInfo));
                Console.WriteLine("El cuadrado de " + numInfo + ": " + numInfo * numInfo);
                if (numInfo > 0)
                {
                    Console.WriteLine("La raiz cuadrada de " + numInfo + ": " + Single.Sqrt(numInfo));
                }
                else
                {
                    Console.WriteLine("La raiz cuadrada del numero ingresado no es un numero real");
                }
                Console.WriteLine("El seno de " + numInfo + ": " + Single.Sin(numInfo));
                Console.WriteLine("El coseno de " + numInfo + ": " + Single.Cos(numInfo));
                var numString = numInfo.ToString();
                string[] arrNumString = numString.Split(',');
                Console.WriteLine("La parte entera de " + numInfo + ": " + arrNumString[0]);
                Console.Write("Ingrese otro numero: ");
                string? secondInput = Console.ReadLine();
                if (Single.TryParse(secondInput, out float n2))
                {
                    float num1C = Single.Parse(secondInput);
                    Console.Write("Ingrese otro numero: ");
                    string? thirdInput = Console.ReadLine();
                    if (Single.TryParse(thirdInput, out float n3))
                    {
                        float num2C = Single.Parse(thirdInput);
                        if (num1C > num2C)
                        {
                            Console.WriteLine("El maximo entre " + num1C + " y " + num2C + " es " + num1C);
                            Console.WriteLine("El minimo entre " + num1C + " y " + num2C + " es " + num2C);
                        }
                        else
                        {
                            Console.WriteLine("El maximo entre " + num1C + " y " + num2C + " es " + num2C);
                            Console.WriteLine("El minimo entre " + num1C + " y " + num2C + " es " + num1C);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No ha ingresado un numero.");
                    }
                }
                else
                {

                    Console.WriteLine("No ha ingresado un numero asignado a una operacion existente. Intente nuevamente");
                }
            }
        }
        else
        {
            Console.WriteLine("No ha ingresado un numero.");
        }
    }
}
public class showResult
{
    public void mostrar(float resultado)
    {
        Console.WriteLine("Resultado: " + resultado);
    }
}