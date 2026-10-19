// EQUIPO3_INTEGRANTE_1_JORGE JAVIER GARCIA MORENO_INTEGRANTE_2_CARLOS IVAN VÁZQUEZ ACEVEDO
// Problema: Personalizar los colores de los símbolos de un personaje en la consola
// Objetivo: Mostrar la imagen original y después con los colores elegidos por el usuario
// Entradas: Color para #, + y @
// SALIDAS: Imagen original e imagen personalizada con los colores seleccionados

string[] sprite =
{
    " ", " ", "#", "#", "#", "#", "#", " ", " ", "SALTO",
    " ", "#", "#", "+", "+", "+", "#", "#", " ", "SALTO",
    "#", "+", "+", "@", "+", "@", "+", "+", "#", "SALTO",
    "#", "+", "+", "+", "+", "+", "+", "+", "#", "SALTO",
    "#", "+", "+", "#", "#", "#", "+", "+", "#", "SALTO",
    " ", "#", "#", "+", "+", "+", "#", "#", " ", "SALTO",
    " ", " ", "#", " ", " ", " ", "#", " ", " ", "SALTO"
};

// 1. mostrar el personaje original
Console.WriteLine("personaje original");

for (int i = 0; i < sprite.Length; i++)
{
    // si encuentra "SALTO", baja al siguiente renglón
    if (sprite[i] == "SALTO")
    {
        Console.WriteLine();
    }
    // si no imprime sin bajar de renglón
    else
    {
        Console.Write(sprite[i]);
    }
}

// 2. Mostrar los colores disponibles
Console.WriteLine("\n=== PERSONALIZAR PERSONAJE ===");
Console.WriteLine("Colores disponibles: red, green, blue, yellow, cyan, magenta, white");
Console.WriteLine("Escribe la opcion elegida exactamenete como se muestra");

Console.Write("Color para #: ");
string colorHashtag = Console.ReadLine();

Console.Write("Color para +: ");
string colorMas = Console.ReadLine();

Console.Write("Color para @: ");
string colorArroba = Console.ReadLine();

//3. Mostrar el personaje con los cambios
Console.WriteLine("\nPersonaje personalizado");

for (int i = 0; i < sprite.Length; i++)
{
    if (sprite[i] == "SALTO")
    {
        Console.WriteLine();
    }
    else
    {
        // elegir el color del simbolo #
        if (sprite[i] == "#")
        {
            if (colorHashtag == "red")
                Console.ForegroundColor = ConsoleColor.Red;
            else if (colorHashtag == "green")
                Console.ForegroundColor = ConsoleColor.Green;
            else if (colorHashtag == "blue")
                Console.ForegroundColor = ConsoleColor.Blue;
            else if (colorHashtag == "yellow")
                Console.ForegroundColor = ConsoleColor.Yellow;
            else if (colorHashtag == "cyan")
                Console.ForegroundColor = ConsoleColor.Cyan;
            else if (colorHashtag == "magenta")
                Console.ForegroundColor = ConsoleColor.Magenta;
            else
                Console.ForegroundColor = ConsoleColor.White;
        }

        // Elegir el color del simbolo +
        if (sprite[i] == "+")
        {
            if (colorMas == "red")
                Console.ForegroundColor = ConsoleColor.Red;
            else if (colorMas == "green")
                Console.ForegroundColor = ConsoleColor.Green;
            else if (colorMas == "blue")
                Console.ForegroundColor = ConsoleColor.Blue;
            else if (colorMas == "yellow")
                Console.ForegroundColor = ConsoleColor.Yellow;
            else if (colorMas == "cyan")
                Console.ForegroundColor = ConsoleColor.Cyan;
            else if (colorMas == "magenta")
                Console.ForegroundColor = ConsoleColor.Magenta;
            else
                Console.ForegroundColor = ConsoleColor.White;
        }

        // color del simbolo @
        if (sprite[i] == "@")
        {
            if (colorArroba == "red")
                Console.ForegroundColor = ConsoleColor.Red;
            else if (colorArroba == "green")
                Console.ForegroundColor = ConsoleColor.Green;
            else if (colorArroba == "blue")
                Console.ForegroundColor = ConsoleColor.Blue;
            else if (colorArroba == "yellow")
                Console.ForegroundColor = ConsoleColor.Yellow;
            else if (colorArroba == "cyan")
                Console.ForegroundColor = ConsoleColor.Cyan;
            else if (colorArroba == "magenta")
                Console.ForegroundColor = ConsoleColor.Magenta;
            else
                Console.ForegroundColor = ConsoleColor.White;
        }

        Console.Write(sprite[i]);
        Console.ResetColor();
    }
}
