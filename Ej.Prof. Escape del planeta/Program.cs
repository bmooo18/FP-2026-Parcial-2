// Escape del planeta
// Problema: Crear una nave que deba abandonar la atmosfera
// Objetivo:
// Entradas:
// Salidas:

const int   DISTANCIA_AL_ESPACIO_KM   = 10;
const int   COMBUSTIBLE_INICIAL       = 100;
const int   COMBUSTIBLE_POR_TURNO     = 4;
const int   PERDIDA_KM_POR_ESPERA     = 2;
const int   ASCENSO_POR_TURNO         = 1;
const int   ESCUDO_MAXIMO             = 25;
const int   ESCUDO_POR_TURNO          = 2;
const float ZONA_CALMA_BONO_ESCUDO    = 1.5F;
const float DMG_ESCOMBRO              = 5;
const int   COMBUSTIBLE_PARA_ESQUIVAR = 2;

var kmRecorridos      = 0;
var combustibleActual = COMBUSTIBLE_INICIAL;
var escudoActual = 10f;

Console.WriteLine("Bienvenido a la simulacion de viaje al espacio");
Console.WriteLine($"Distancia: {kmRecorridos}");
Console.WriteLine($"Combustible: {combustibleActual}");
Console.WriteLine($"Escudo: {escudoActual}");

while (kmRecorridos < DISTANCIA_AL_ESPACIO_KM && combustibleActual > 0)
{
    var esZonaDeEscombros = true;
    var esZonaDeCalma = false;
    var esZonaNeutral = !esZonaDeCalma && !esZonaDeEscombros;

    string opcion;
    bool   seleccionValida;

    do
    {
        if (esZonaDeEscombros)
        {
            Console.WriteLine("\nEs zona de escombros:");
            Console.WriteLine("\nQue accion quieres realizar:");
            Console.WriteLine("1. Ascender");
            Console.WriteLine("2. Esperar...");
            if (combustibleActual >= COMBUSTIBLE_PARA_ESQUIVAR)
            {
                Console.WriteLine("3. Esquivar...");
            }
            else
            {
                Console.WriteLine("3. Esquivar (Sin combustible)");
            }
        }
        else if (esZonaDeCalma)
        {
            Console.WriteLine("\nEs zona de calma:");
            Console.WriteLine("\nQue accion quieres realizar:");
            Console.WriteLine("1. Ascender");
            Console.WriteLine("2. Esperar (bono de escudo)");
        }
        else if (esZonaNeutral)
        {
            Console.WriteLine("\nEs zona neutral:");
            Console.WriteLine("\nQue accion quieres realizar:");
            Console.WriteLine("1. Ascender");
            Console.WriteLine("2. Esperar...");
        }


        opcion = Console.ReadLine() ?? "";

        //simplificar y validar todas sin tener que copiar
        var seleccionoOpcion1 = opcion == "1";
        var seleccionoOpcion2 = opcion == "2";
        var seleccionoOpcion3 = opcion == "3" && esZonaDeEscombros;

        seleccionValida = seleccionoOpcion1 || seleccionoOpcion2 || seleccionoOpcion3;

        if (seleccionValida == false);
        {
            Console.WriteLine("Opcion no válida. Intenta de nuevo");
        }

    } while (seleccionValida == false);


    if (opcion == "1")
    {
        if (esZonaDeEscombros)
        {
            escudoActual = Math.Max(
                                    0,
                                    escudoActual - DMG_ESCOMBRO
                                   );

            // > flow.epsilon, si trabajas con calculos, que no podrian llegar a 0 exacto
            // De los pocos usos de if que no ocupa {}
            if (escudoActual == 0) break;

            Console.WriteLine("Recibiste daño de los escombros...");
        }
        Console.WriteLine("Ascendiendo...");
        kmRecorridos      += ASCENSO_POR_TURNO;
        combustibleActual -= COMBUSTIBLE_POR_TURNO;
    }
    else if (opcion == "2")
    {
        Console.WriteLine("Esperarando...");

        // shortcut de if que elige un
        var bonoTurno = esZonaDeCalma ? ZONA_CALMA_BONO_ESCUDO : 1f;

        var escudoTurno = escudoActual + ESCUDO_POR_TURNO * bonoTurno;

        escudoActual = Math.Min(
                                ESCUDO_MAXIMO,
                                escudoTurno
                                );
        if (esZonaDeEscombros)
        {
            escudoActual = Math.Max(
                                    0,
                                    escudoActual - DMG_ESCOMBRO
                                   );

            // > flow.epsilon, si trabajas con calculos, que no podrian llegar a 0 exacto
            // De los pocos usos de if que no ocupa {}
            if (escudoActual == 0) break;

            Console.WriteLine("Recibiste daño de los escombros...");
        }
        kmRecorridos = Math.Max(
                                0,
                                kmRecorridos - PERDIDA_KM_POR_ESPERA
                                );
    }
    else if (opcion == "3")
    {
        if (combustibleActual >= COMBUSTIBLE_PARA_ESQUIVAR)
        {
            Console.WriteLine("Haz esquivado los escombros");
            combustibleActual -= COMBUSTIBLE_PARA_ESQUIVAR;
        }
        else
        {
            escudoActual = Math.Max(
                                    0,
                                    escudoActual - DMG_ESCOMBRO
                                   );

            if (escudoActual == 0) break;

            Console.WriteLine("Recibiste daño de los escombros...");
        }
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
