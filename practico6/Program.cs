// ------------------ Ejercicio 1 ------------------
// Console.WriteLine("Ingrese un numero: ");
// string? g = Console.ReadLine();
// if (Single.TryParse(g, out float num))
// {
//     float numero = Single.Parse(g);
//     if (numero > 0)
//     {
//         float inverted = 1 / numero;
//         Console.WriteLine("El numero que se obtuvo es: " + inverted);
//     }
//     else
//     {
//         Console.WriteLine("El numero ingresado no es valido.");
//     }
// }
// else
// {
//     Console.WriteLine("No ha ingresado un numero.");
// }

// ------------------ Ejercicio 4 ------------------

Console.Write("Ingrese una cadena de texto: ");
string? cadena1 = Console.ReadLine();
Console.WriteLine($"La cadena ingresada tiene una longitud de: {cadena1?.Length}");
Console.Write("Ingrese una nueva cadena de texto: ");
string? cadena2 = Console.ReadLine();
Console.WriteLine("---- Concatenacion ----");
Console.WriteLine(cadena1 + cadena2);
string[]? subCadena = cadena2!.Split(" ");
if (subCadena.Length == 1)
{
    string[]? subCadena2 = cadena2!.Split("e");
    Console.WriteLine("Subcadena de la cadena ingresada: " + subCadena2[0]);
}
else
{
    Console.WriteLine("Subcadena de la cadena ingresada: " + subCadena[0]);
}

Console.WriteLine("---- Calculadora ----");
Console.Write("Ingrese un numero: ");
string? n1 = Console.ReadLine();
if (Single.TryParse(n1, out float num1))
{
    Console.Write("Ingrese otro numero: ");
    string? n2 = Console.ReadLine();
    float numero1 = Single.Parse(n1);
    if (Single.TryParse(n2, out float num2))
    {
        float numero2 = Single.Parse(n2);
        Console.WriteLine($"La suma entre {numero1} y {numero2} es igual a: {numero1 + numero2}");

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

Console.WriteLine($"=====| Se trabajara con la cadena: {cadena1} |=====");
Console.WriteLine("---- Recorrer cadena ----");
foreach (char charac in cadena1!)
{
    Console.WriteLine(charac);
}
Console.WriteLine("---- Busqueda en string ----");

Console.Write("Ingrese una cadena para buscarla en la anterior ingresada: ");
string? searchString = Console.ReadLine();

if (cadena1.Contains(searchString!))
{
    Console.WriteLine($"El index de inicio de la cadena ingresada en la cadena principal es: {cadena1.IndexOf(searchString!)}");
}
else
{
    Console.WriteLine($"La cadena de texto ingresada no esta contenida en: {cadena1}");
}

Console.WriteLine($"Cadena en minusculas: {cadena1.ToLower()}");
Console.WriteLine($"Cadena en mayusculas: {cadena1.ToUpper()}");

Console.Write("Ingrese una nueva cadena: ");
string? cadena3 = Console.ReadLine();
Console.Write(@"¿Con que cadena quiere separarla?: ");
string? separator = Console.ReadLine();
if (cadena3!.Contains(separator!))
{
    Console.WriteLine("// La cadena ingresada esta contenida en la primer cadena.");
    Console.WriteLine("// Tiene sentido realizar un split() [Separacion] de la cadena.");
    Console.WriteLine("// Sin embargo, los cambios que esto realiza recaen en el tipo de dato");
    Console.WriteLine("// pues, retorna un array de la siguiente forma:");
    Console.WriteLine("// Ej: string cadena = \" Akshan > any TopLaner in the game\" ");
    Console.WriteLine("// string[] splitted = cadena.split(\"TopLaner\") // Resultado: [\"Akshan > any \",\" in the game\"]");
    Console.WriteLine("// Como se puede ver, el array contiene toda la cadena exceptuando el separador escogido.");
    string[] separated = cadena3.Split(separator); 
    Console.WriteLine("---- Para este caso ----");
    Console.WriteLine($"Quedaria asi, luego de convertirlo en string nuevamente es: {string.Concat(separated)}");
}
else
{
    Console.WriteLine($"La cadena \"{separator}\" no esta contenida en: {cadena3}");
}