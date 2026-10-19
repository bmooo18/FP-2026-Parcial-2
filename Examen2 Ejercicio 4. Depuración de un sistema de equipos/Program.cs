// EQUIPO3_INTEGRANTE_1_JORGE JAVIER GARCIA MORENO_INTEGRANTE_2_CARLOS IVAN VÁZQUEZ ACEVEDO
// errores: 2 de sintaxis y 3 de logica


Console.Write("Cantidad de jugadores: ");
int playerCount = int.Parse(Console.ReadLine());


string[] players = new string[playerCount];


for (int i = 0; i < playerCount; i++)
{
    Console.Write($"Nombre {i + 1}: ");
    players[i] = Console.ReadLine();
}


Console.Write("Integrantes por equipo: ");
int teamSize = int.Parse(Console.ReadLine());


Random.Shared.Shuffle(players);


int team = 1;
Console.WriteLine($"Equipo {team}:"); // error sintaxis 1: se elimina el paréntesis extra


for (int i = 0; i < players.Length; i++) // Error 2 lógica: se elimina -1 para incluir al último jugador
{
    if (i > 0 && i % teamSize == 0) // ERROR 3 lógica: se cambia == 1 por == 0 para iniciar un equipo nuevo
    {
        team++;
        Console.WriteLine($"Equipo {team}:");
    } // error 4 sintaxis: faltaba } para cerrar el if


    Console.WriteLine(players[i]); // error 5 lógica: se imprime cada jugador fuera del if, para no omitir jugadores
    // error 6 sintaxis: se quita % teamSize, porque hace que se repitan jugadores
}
