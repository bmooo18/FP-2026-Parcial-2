//E2 - Genera un programa que pida un numeros entero hasta encontrar el correcto

string num;
bool   si;
int    numINT;
int    numCorrecto = 5;

do
{
    Console.WriteLine("Dame un numero entero");
    num = Console.ReadLine();
    si  = int.TryParse(num, out numINT);
    if (si == true)
    {
        if (numINT == numCorrecto)
        {
            Console.WriteLine("Numero correcto");
        }
        else
        {
            Console.WriteLine("Numero incorrecto, dame otro numero entero");
        }
    }
    else
    {
        Console.WriteLine("Dato no valido ");
    }

} while (numCorrecto != numINT);
