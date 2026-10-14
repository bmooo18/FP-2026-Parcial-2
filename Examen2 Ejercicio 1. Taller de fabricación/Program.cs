// // Genera un programa que haga
// Entradas: hachas, palas, picos, lanzas y martillos

Random rnd            = new Random();
int    maderaRecibida = rnd.Next(100, 1000 + 1);


List<string> items = new List<string>();


Console.WriteLine("Tu madera actual es: " + maderaRecibida);


string opcion;
bool   seleccionValida;

// Pedir ordenes
do
{
    Console.WriteLine("\nDime que orden quieres hacer:");
    Console.WriteLine("1. Hacha");
    Console.WriteLine("2. Pala");
    Console.WriteLine("3. Pico");
    Console.WriteLine("4. Lanza");
    Console.WriteLine("5. Martillo");
    Console.WriteLine("Escribe cualquier otra cosa para salir");

    opcion = Console.ReadLine() ?? "";

    //simplificar y validar todas sin tener que copiar
    var seleccionoOpcion1 = opcion == "1";
    var seleccionoOpcion2 = opcion == "2";
    var seleccionoOpcion3 = opcion == "3";
    var seleccionoOpcion4 = opcion == "4";
    var seleccionoOpcion5 = opcion == "5";

    seleccionValida = seleccionoOpcion1 || seleccionoOpcion2 || seleccionoOpcion3 || seleccionoOpcion4 || seleccionoOpcion5;

    if (seleccionValida == false)
    {
        Console.WriteLine("Opcion de salida");
    }
    else if (opcion == "1")
    {
        items.Add("Hacha");
    }
    else if (opcion == "2")
    {
        items.Add("Pala");
    }
    else if (opcion == "3")
    {
        items.Add("Pico");
    }
    else if (opcion == "4")
    {
        items.Add("Lanza");
    }
    else if (opcion == "5")
    {
        items.Add("Martillo");
    }

} while (seleccionValida == true);

// Producir ordenes
if (maderaRecibida > 100)
{
    // Cuando necesitas conocer el índice o controlar el recorrido
    for (int i = 0; i < items.Count; i++)
    {
        Console.WriteLine($"{i}: {items[i]}");
    }

// for(iterador; condición; cambio)
}











