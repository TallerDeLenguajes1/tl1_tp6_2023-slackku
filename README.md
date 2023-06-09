# tl1_tp6_2023-slackku
Desarrollo de las actividades planteadas para en el Trabajo Practico N° 6 de Taller de Lenguajes 1
## Ejercico 4
**¿String es una tipo por valor o un tipo por referencia?**

String es un tipo de dato por referencia, pues almacena referencias en sus datos.

**Secuencias de escape del tipo String:**
- "\\\\": Barra diagonal inversa.
- "\n": Salto de linea.
- "\t": Una tabulación horizontal.
- "\\'": Comillas simples.
- "\b": Un retroceso.
- "\f": Avance de página.
- Simbolos Unicode, ej: "\u2705" mostrara: ✅.
**¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?**

El carácter `@` actua como identificador textual, este define un literal de cadena textual. Para una mejor comprensión esta el siguiente ejemplo:
```csharp
string literal = @"Soy: \u2705";
string noLiteral = "Soy: \u2705";

Console.WriteLine(literal);
Console.WriteLine(noLiteral);

// El ejemplo muestra el siguiente output:
//      Soy: \u2705
//      Soy: ✅
```
El carácter `$` identifica un literal de cadena como una cadena interpolada, lo que permite contener expresiones de interpolación. Para una mejor comprensión esta el siguiente ejemplo:

```csharp
string nombre = "Ignacio";
string ocupacion = "estudiante";

Console.WriteLine($"Hola, me llamo {nombre}! y soy un {ocupacion}.");
// El ejemplo muestra el siguiente output:
// Hola, me llamo Ignacio y soy un estudiante.

```
Sin el uso de la interpolación se tendria que realizar de la siguiente forma:
```csharp
string nombre = "Ignacio";
string ocupacion = "estudiante";

Console.WriteLine("Hola, me llamo {0}! y soy un {1}.", nombre, ocupacion);
// El ejemplo muestra el siguiente output:
// Hola, me llamo Ignacio y soy un estudiante.
// (Tal cual como el anterior)
```
## Autor
- José Ignacio Lorenzo - _Alumno_ - [slackku](https://github.com/slackku)