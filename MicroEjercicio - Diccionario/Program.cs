Dictionary<string, int> items = new()
                                {
                                    { "Espada", 25 },
                                    { "Arco", 15 },
                                    { "Hacha", 35 },
                                };

Console.WriteLine(items["Espada"]);
Console.WriteLine(items["Hacha"]);

items["Arco"] = 20;

Console.WriteLine(items["Arco"]);

//verifica que haya una clave llamada hoz
if(items.ContainsKey("Hoz")) {
    Console.WriteLine("DMG Hoz: " + items["Hoz"]);
}

//Modifica el if para que utilice TryGetValue
if(items.TryGetValue("Hoz", out int HozDmg) == true)
{
    Console.WriteLine($"DMG hacha: {HozDmg}");
}

//intenta obtener el valor y cambiarlo
if(items.TryGetValue("Hacha", out int dmg))
{
    Console.WriteLine($"DMG hacha: {dmg}");
}

//Modifica el if para que utilice ContainsKey
if(items.ContainsKey("Hacha"))
{
    Console.WriteLine($"DMG hacha: {items["Hacha"]}");
}

//iNTENTA OBTENER "Arco", si no existe agregalo
if (items.ContainsKey("Arco") == false)
{ // false
    items.Add("Arco", 20);

}
else
{
    Console.WriteLine($"DMG Arco: {items["Arco"]}");
}

//Equivalente
items.TryAdd("Arco", 20);


//iNTENTA OBTENER "Cuchillo", si no existe agregalo
if (items.ContainsKey("Cuchillo") == false)
{ // true
    items.Add("Cuchillo", 20);
    Console.WriteLine($"DMG Cuchillo: {items["Cuchillo"]}");
}

//Obtiene la cantidad de elementos que estan obtenidos
Console.WriteLine(items.Count);

items.Clear();
Console.WriteLine(items.Count);
