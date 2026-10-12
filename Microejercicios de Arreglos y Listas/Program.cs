// Genera un log de batalla de forma manual y muestra el resultado:
/*
1. Player ataca por 5
2. Enemy ataca por 6
3. Player ataca por 7 (crit)
4. ¡Enemy aturdido!
5. Player ataca por 5
6. ¡Enemy ha muerto!
*/

// Arreglo
// Log de batalla usando un arreglo
string[] logBatallaArray = new string[6];

logBatallaArray[0] = "Player ataca por 5";
logBatallaArray[1] = "Enemy ataca por 6";
logBatallaArray[2] = "Player ataca por 7 (crit)";
logBatallaArray[3] = "¡Enemy aturdido!";
logBatallaArray[4] = "Player ataca por 5";
logBatallaArray[5] = "¡Enemy ha muerto!";

// Mostrar el log de batalla
Console.WriteLine("LOG DE BATALLA (ARREGLO)");

for (int i = 0; i < logBatallaArray.Length; i++)
{
    Console.WriteLine($"{i + 1}. {logBatallaArray[i]}");
} ;

Console.WriteLine("\n");
// Lista
List<string> logBatallaList = new List<string>();

logBatallaList.Add("Player ataca por 5");
logBatallaList.Add("Enemy ataca por 6");
logBatallaList.Add("Player ataca por 7 (crit)");
logBatallaList.Add("¡Enemy aturdido!");
logBatallaList.Add("Player ataca por 5");
logBatallaList.Add("¡Enemy ha muerto!");

// Mostrar el log de batalla
Console.WriteLine("LOG DE BATALLA (LISTA)");

for (int i = 0; i < logBatallaList.Count; i++)
{
    Console.WriteLine($"{i + 1}. {logBatallaList[i]}");
} ;


Console.WriteLine("\n");
//Genera un programa que administre los enemigos activos de una zona. Muestra el estado en cada paso:
/*
1. Slime, Globlin, Skeleton
2. Aparece Orc
3. Muere un Slime
4. Aparece Orc
5. Muere Orc
*/

// Arreglo
string[] enemigos = new string[10];
int      cantidad = 3;

enemigos[0] = "Slime";
enemigos[1] = "Globlin";
enemigos[2] = "Skeleton";

Console.WriteLine("Paso 1: Slime, Globlin, Skeleton");

enemigos[cantidad] = "Orc";
cantidad++;
Console.WriteLine("Paso 2: Slime, Globlin, Skeleton, Orc");

enemigos[0] = enemigos[1];
enemigos[1] = enemigos[2];
enemigos[2] = enemigos[3];
cantidad--;
Console.WriteLine("Paso 3: Globlin, Skeleton, Orc");

enemigos[cantidad] = "Orc";
cantidad++;
Console.WriteLine("Paso 4: Globlin, Skeleton, Orc, Orc");

cantidad--;
Console.WriteLine("Paso 5: Globlin, Skeleton, Orc");

Console.WriteLine("\n");
// Lista
List<string> enemigosList = new List<string>()
                        {
                            "Slime", "Globlin", "Skeleton"
                        };

Console.WriteLine("Paso 1: " + string.Join(", ", enemigosList));

enemigosList.Add("Orc");
Console.WriteLine("Paso 2: " + string.Join(", ", enemigosList));

enemigosList.Remove("Slime");
Console.WriteLine("Paso 3: " + string.Join(", ", enemigosList));

enemigosList.Add("Orc");
Console.WriteLine("Paso 4: " + string.Join(", ", enemigosList));

enemigosList.Remove("Orc");
Console.WriteLine("Paso 5: " + string.Join(", ", enemigosList));

