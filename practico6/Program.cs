Console.WriteLine("Ingrese un numero: ");
string? g = Console.ReadLine();
if (Single.TryParse(g, out float num))
{
    float numero = Single.Parse(g);
    if (numero > 0)
    {
        float inverted = 1 / numero;
        Console.WriteLine("El numero que se obtuvo es: " + inverted);
    }
    else
    {
        Console.WriteLine("El numero ingresado no es valido.");
    }
}
else
{
    Console.WriteLine("No ha ingresado un numero.");
}