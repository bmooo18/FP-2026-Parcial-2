// E1 - Genera un log de combate
int    daño   = 5;
Random rnd    = new Random();
int    numero = rnd.Next(1,50);
int    vida   = numero;
int    vidaDSP;

while (vida >= 0)
{
    Console.WriteLine("Vida del enemigo: " + vida);
    vida = vida - daño;
    Console.WriteLine("Vida del enemigo despues del ataque: " + vida);
    Console.WriteLine("\n");
}
