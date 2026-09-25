// Escape del planeta
// Problema: Crear una nave que deba abandonar la atmosfera
// Objetivo:
// Entradas:
// Salidas:

const int DISTANCIA_AL_ESPACIO_KM = 10;
const int COMBUSTIBLE_INICIAL     = 100;
const int COMBUSTIBLE_POR_TURNO   = 4;
const int PERDIDA_KM_POR_ESPERA   = 2;
const int ASCENSO_POR_TURNO       = 1;
const int ESCUDO_MAXIMO           = 25;
const int ESCUDO_POR_TURNO        = 2;

var kmRecorridos      = 0;
var combustibleActual = COMBUSTIBLE_INICIAL;
var escudoActual = ESCUDO_MAXIMO;

Console.WriteLine("Bienvenido a la simulacion de viaje al espacio");
Console.WriteLine($"Distancia: {kmRecorridos}");
Console.WriteLine($"Combustible: {combustibleActual}");
Console.WriteLine($"Escudo: {escudoActual}");

while (kmRecorridos < DISTANCIA_AL_ESPACIO_KM && combustibleActual > 0)
{
    var esZonaDeEscombros = false;
    var esZonaDeCalma = false;
    var esZonaNeutral = !esZonaDeCalma && !esZonaDeEscombros;

    string opcion;

    do
    {
        if (esZonaDeEscombros)
        {
            Console.WriteLine("\nEs zona de escombros:");
        }
        else if (esZonaDeCalma)
        {
            Console.WriteLine("\nEs zona de calma:");
        }
        else if (esZonaNeutral)
        {
            Console.WriteLine("\nEs zona neutral:");
        }

        Console.WriteLine("\nQue accion quieres realizar:");
        Console.WriteLine("1. Ascender");
        Console.WriteLine("2. Esperar...");
        opcion = Console.ReadLine() ?? "";

        if (opcion != "1" && opcion != "2")
        {
            Console.WriteLine("Opcion no válida. Intenta de nuevo");
        }

    } while (opcion != "1" && opcion != "2" );


    if (opcion == "1")
    {
        Console.WriteLine("Ascendio...");
        kmRecorridos      += ASCENSO_POR_TURNO;
        combustibleActual -= COMBUSTIBLE_POR_TURNO;
    }
    else if (opcion == "2")
    {
        Console.WriteLine("Esperarando...");
        escudoActual = Math.Min(
                                ESCUDO_MAXIMO,
                                escudoActual + ESCUDO_POR_TURNO
                                );
        kmRecorridos = Math.Max(
                                0,
                                kmRecorridos - PERDIDA_KM_POR_ESPERA
                                );
    }

    Console.WriteLine($"Distancia: {kmRecorridos}");
    Console.WriteLine($"Combustible: {combustibleActual}");
    Console.WriteLine($"Escudo: {escudoActual}");
}

if (kmRecorridos >= DISTANCIA_AL_ESPACIO_KM)
{
    Console.WriteLine("¡Llegaste al espacio!");
}
else
{
    Console.WriteLine("¡No llegaste al espacio!");
}
