// EQUIPO3_INTEGRANTE_1_JORGE JAVIER GARCIA MORENO_INTEGRANTE_2_CARLOS IVAN VÁZQUEZ ACEVEDO
// Problema: Genera un programa que administre un taller de fabricación de herramientas, donde se registre una cantidad de madera, se reciban órdenes de fabricación, se registren las ordenes, se produzcan
// Objetivo: Administrar los recursos y las órdenes del taller, controlando la madera utilizada y restante, respetando el orden de las solicitudes y mostrando un reporte final con los costos y la cantidad de herramientas fabricadas de cada tipo
// Entradas: Cantidad de madera, Ordenes de fabricacion (hachas, palas, picos, lanzas y martillos)
// SALIDAS: Cantidad total, utilizada y restante de madera. Lista de órdenes recibidas Herramientas fabricadas, Costo de fabricación, Cantidad fabricada

// ETAPA 0: Definir precios y madera
int[]    costos       = { 20, 15, 30, 25, 35 };
string[] herramientas = { "Hacha", "Pala", "Pico", "Lanza", "Martillo" };

int   maderaInicial   = new Random().Next(100, 1000 + 1);
int   madera          = maderaInicial;
int[] ordenes         = new int[1000];
int   cantidadOrdenes = 0;

int[] fabricadas      = new int[5];
int   maderaUtilizada = 0;

Console.WriteLine("Taller de fabricacion");
Console.WriteLine("Madera inicial: " + maderaInicial);

Console.WriteLine("\nCostos de fabricación:"); //Recorre las herramientas
for (int i = 0; i < herramientas.Length; i++)
{
    Console.WriteLine($"{i}: {herramientas[i]}" + ":" + costos[i]);
}

// etapa 1: Pedir órdenes
Console.WriteLine("\nIngresa el numero de herramienta:");
Console.WriteLine("0 = Hacha");
Console.WriteLine("1 = Pala");
Console.WriteLine("2 = Pico");
Console.WriteLine("3 = Lanza");
Console.WriteLine("4 = Martillo");
Console.WriteLine("-1 = Terminar órdenes");

string opcion;
bool   si;
int    opcionINT;

do // validar que sean los datos solicitados y repetir hasta que se quiera cancelar
{
    Console.WriteLine("\nDame el numero de orden");
    opcion = Console.ReadLine();
    si  = int.TryParse(opcion, out opcionINT);
    if (si == true)
    {
        if (opcionINT >= 0 && opcionINT < 5)
        {
            // guarda el número de la herramienta en la siguiente posición disponible del arreglo
            ordenes[cantidadOrdenes] = opcionINT;
            // aumenta el contador para que la próxima orden se guarde en otra posición
            cantidadOrdenes          = cantidadOrdenes + 1;
            Console.WriteLine("Orden registrada");
        }
        else if (opcionINT != -1)
        {
            Console.WriteLine("Opción inválida");
        }
    }
    else
    {
        Console.WriteLine("Dato no valido");
    }

} while (opcionINT != -1);

// Etapa 2: Producir órdenes
Console.WriteLine("\nProduccion");

//recorre las ordenes registradas
for (int i = 0; i < cantidadOrdenes; i++)
{
    // obtiene el número de la herramienta solicitada
    int herramienta = ordenes[i];
    // busca cuánta madera necesita esa herramienta
    int costo       = costos[herramienta];

    if (madera >= costo)
    {
        madera                  = madera - costo;
        maderaUtilizada         = maderaUtilizada + costo;
        fabricadas[herramienta] = fabricadas[herramienta] + 1; // Aumenta en uno el contador de esa herramienta

        Console.WriteLine("Fabricada: " + herramientas[herramienta]);
    }
    else
    {
        Console.WriteLine(
                          "No hay madera suficiente para fabricar: "
                          + herramientas[herramienta]
                         );
        Console.WriteLine("Producción detenida");
        break;
    }
}

// ETAPA 3: Mostrar órdenes y reporte
Console.WriteLine("\nOrdenes recibidas");

//recorre las ordenes registrada
for (int i = 0; i < cantidadOrdenes; i++)
{
    Console.WriteLine((i + 1) + ". " + herramientas[ordenes[i]]);
}

Console.WriteLine("\nReporte fianl:");
Console.WriteLine("Madera inicial: " + maderaInicial);
Console.WriteLine("Madera utilizada: " + maderaUtilizada);
Console.WriteLine("Madera restante: " + madera);

Console.WriteLine("\nCostos y herramientas fabricadas:");

// recorre las 5 herramientas
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(herramientas[i] + " / Costo: " + costos[i] + " / Fabricadas: " + fabricadas[i]);
}











