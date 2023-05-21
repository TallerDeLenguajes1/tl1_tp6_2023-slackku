Console.Write("|--------------------------------------------------|\n");
Console.Write("|                  CALCULADORA V1                  |\n");
Console.Write("|--------------------------------------------------|\n");
Console.Write(" Suma: 1, Resta: 2, Multiplicacion: 3, Division: 4\n");
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
        Console.WriteLine("No ha ingresado un numero asignado a una operacion existente. Intente nuevamente");
    }
}
else
{
    Console.WriteLine("No ha ingresado un numero.");
}

public class showResult
{
    public void mostrar(float resultado)
    {
        Console.WriteLine("Resultado: " + resultado);
    }
}