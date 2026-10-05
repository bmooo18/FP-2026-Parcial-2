# Guia de programacion

## Referencias rapidas para el Markdown

| Objetivo          |                                    Markdown |
|:------------------|--------------------------------------------:|
| Encabezado 1      |                                # Encabezado |
| Negrita           |                               ## Encabezado |
| Negrita           |                                 **texto**   |
| Cursiva           |                                     *texto* |
| Negrita + cursiva |                                 ***texto*** |
| Tachado           |                                   ~~texto~~ |
| Enlace            | [ Encabezado]([texto](https://example.com)) |
| Imagen            |                          ![alt](imagen.png) |
| Código en línea   |                                    `código` |
| Cita              |                                      > cita |
| Viñeta            |                                  - elemento |
| Elemento numerado |                                 1. elemento |
| Tarea             |                                 - [ ] tarea |
| Línea horizontal  |                                         --- |

________________________________________________________________________________________

## Un flujo breve para analizar y resolver problemas


* Paso 1: Comprender el problema
* Identificar datos de entrada
* Identificar datos de salida
* Identificar restricciones


* Paso 2: Diseñar el algoritmo
* Escribir pasos en pseudocódigo
* Identificar operaciones necesarias


* Paso 3: Implementar
* Escribir código
* Usar nombres descriptivos
* Agregar comentarios


* Paso 4: Probar
* Probar con valores válidos
* Probar con valores límite
* Probar con valores inválidos


* Paso 5: Refinar
* Eliminar redundancias
* Mejorar legibilidad

________________________________________________________________________________________

## Una referencia breve para debugging, es decir, qué hacer si mi programa no funciona.


* Leer mensajes de error (indican problema y línea)
* Usar Console.WriteLine para mostrar valores intermedios
* Validar entrada del usuario
* Probar con casos simples

________________________________________________________________________________________

## 1. Entrada y salida por consola


Los dos son comandos


* `Console.Write` --> No agrega un salto de línea
* `Console.WriteLine` --> Agrega un salto de línea
* `Console.ReadLine()` --> Para solicitar información
  * Al solicitar entradas al usuario, estas se reciben como cadenas


```casharp
Console.WriteLine("¿Cual es tu nombre?");
string nombre = Console.ReadLine();
Console.Write("Hola ");
Console.Write( nombre + "!");
Console.WriteLine(" :)");
```


* `Console.Read()` --> Leer las teclas


* `Console.ReadKey()` --> leer un stream de texto


```casharp
// Solicitamos información al usuario
Console.WriteLine("Dame tu nombre: ");


// Leemos de forma infinita
// Ctrl + z o F6 también termina el programa
while (true)
{
   // Intercepta y muestra la tecla
   // var key = Console. ReadKey();
   // Intercepta y NO muestra la tecla
   var key = Console.ReadKey(true);


   // Si presiona Enter, salimos del bucle
   if(key.Key == ConsoleKey. Enter)
   {
       break;
   }


   // Mostramos la tecla presionada
   Console. Write(key.KeyChar);
}
```

* Comentarios
  * Existen diferentes tipos de comentarios, los principales son de "una línea" y "multilínea"
```casharp
// Comentario de una línea
/*
 * Comentario de
 * más de una
 * línea
*/
// TODO: Agregar todo permite colocar notas para el desarrollador
/// Tres barras permiten colocar comentarios de documentación de una línea
/**
 * Iniciando con dos asteriscos
 * es posible colocar comentarios de
 * documentación de más de una línea
**/

```

________________________________________________________________________________________

## 2. Secuencia de escape
Utilizando dentro de la cadena, es posible hacer que tanto Console. Write como Console. WriteLine muestran caracteres que de otra forma no son posibles.


* `\n (Salto de Línea)`: Agrega una salto de línea ("Enter") al texto.
* `\t (Tabulación)`: Permite alinear bloques de texto en columnas
* `\" (Comillas Dobles)`: Si se quiere insertar una " , es necesario agregar una \ antes para distinguirla del inicio y fin.
* `\\ (Barra Invertida)`: La \ es el carácter inicial de todas las secuencias, у se utiliza para "escapar", quedando como (I cuando se quiere mostrar


```casharp
Console.WriteLine("n\n\n");
//Crear un programa que muestre atributos en forma de tabla con un bader
Console.WriteLine("Estadísticas en forma de tabla");
Console.WriteLine("/ Greg \"El Mago\" /");
Console.WriteLine("\\----------------\\");
Console.WriteLine("/ HP \t100      /");
Console.WriteLine("\\ MP \t50       \\");
Console.WriteLine("/ Gold \t2,500    /");
Console.WriteLine("\\ Exp \t150      \\");
```

________________________________________________________________________________________

## 3. Mostrar valores en una cadenas


* CONCATENACIÓN - Utiliza el signo + para concatenar
```casharp
var sentencias = 6;
var cadena1    = "Hola";
var cadena2    = "mundo";


Console. WriteLine(cadena1 + " " + cadena2 + "!" );
Console.WriteLine("Este programa tiene " + sentencias + " sentencias." );
```


* INTERPOLACIÓN - Utiliza el signo $ para denotar y los valores encerrados en llaves { }
```casharp
var sentencias = 6;
var cadena1 = "Hola";
var cadena2 = "mundo";


Console.WriteLine($"{cadena1} {cadena2}");
Console. WriteLine($"Este programa tiene {sentencias} sentencias.");
```

________________________________________________________________________________________

## 4. Colores de fondo y texto en consola
La consola utiliza colores por defecto, por lo general:
* Fondo: Negro
* Texto: Blanco


Es posible configurar la consola utilizando los siguientes métodos:


* `Console. ForegroundColor`: Permite asignar un color al texto
* `Console. BackgroundColor`: Permite asignar un color al fondo
  Es importante regresar los colores a los valores por defecto al terminar:
* `Console. ResetColor()`: Regresa los colores a valores por defecto


```casharp
// Bandera de México en texto y color
Console.WriteLine("Bandera de México Texto");


Console. ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("MÉ");
Console. ForegroundColor = ConsoleColor.White;
Console. Write("XI");
Console. ForegroundColor = ConsoleColor.Red;
Console. Write("CO");


Console. ResetColor(); // Reiniciamos los colores
Console. WriteLine(); // Salto de línea


Console.WriteLine("Bandera de México Fondo");


// Texto en negro para el contraste
Console. ForegroundColor = ConsoleColor.Black;


Console. BackgroundColor = ConsoleColor. DarkGreen;
Console. Write("MÉ");
Console. BackgroundColor = ConsoleColor. White;
Console.Write("XI");
Console. BackgroundColor = ConsoleColor.Red;
Console. Write("CO");


Console. ResetColor(); // Reiniciamos los colores
```
________________________________________________________________________________________

## 5. Variables y tipos de Dato


Variable: Guarda información que puede cambiar
* variable nameMe

Constante: Guarda información que NO puede cambiar
* const variable NAME_ME


### Obtener y mostrar los valores min y max de un tipo de dato


```casharp
sbyte minValorSbyte = SByte.MinValue;
sbyte maxValorSbyte = SByte.MaxValue;


Console.WriteLine("SByte");
Console.WriteLine("Minimo: " + minValorSbyte);
Console.WriteLine("Maximo: " + maxValorSbyte);
```


### Operadores aritméticos, de comparación y lógicos.
* Símbolo de la suma (+)
* Símbolo de la resta (-)
* Símbolo de la multiplicación (*)
* Símbolo de la división (/)
* Módulo o residuo (%)


### Operadores específicos
* Símbolo de la suma (++) suma 1 al valor (num1++)
* Símbolo de la resta (--) resta 1 al valor (num1--)
* Símbolo de la multiplicación (+) devuelve el valor sin significado (+num1)
* Simbolo de la división (-) devuelve el valor negado del valor (-num1)
```casharp
 //Operaciones Unarias: + y
// Dependiendo de si es sufijo o prefijo, el resultado cambia
//El ejemplo siguiente aplica tanto para la suma (++) como para la resta (-)


var original = 10;            // Comenzamos con 10 entero
// ++ o -- como SUFIJO
// 1. Se guarda el valor de la operación 5 + 10 en 'num2' (Original = 10)
// 2. Se incrementa el valor de 'original' en 1, y se guarda en 'original'
// Resultado: num2 = 5 + 10 = 15 y original = 10 + 1 = 11
var num2     = 5 + original; // num2 = 15


//Original vale 11 ahora
// * -- como PREFIJO
// 1. Se incrementa el valor de 'original' en 1, y se guarda en 'original'
// 2. Se guarda el valor de la operación 5 + 12 en 'num3' (Oriğinal = 12)
// Resultado: original = 12 + 1 = 13 y num3 = 5 + 12 = 17
var num3 = 5 + original; // num3 = 17


// Original vale 12 ahora
// Sugerencia: No utilizar + o -- como parte de una operación aritmética
//             Realiza en incremento/decremento antes o después de form explícita
```


### Tipo de datos


### Números
Los números se pueden separar con guión bajo para facilitar la lectura


* sbyte sbyteVal = -127; // Valores positivos y negativos
* byte byteVal = +255; // Sólo valores positivos
* short shortVal = -32_767; // Valores positivos y negativos
* ushort ushortVal = +65_535; // Solo valores positivos
* int intVal -2_147_483_647; // Valores positivos y negativos
* uint uintVal = +4_294_967_295; // Solo valores positivos, u o U
* long longVal = -9_223_372_036_854_775_807; //Valores positivos y negativos, l o L
* ulong ulongVal = +18_446_744_073_709_551_615; // Solo valores positivos, u o U, l o L
* int randomDash = +1_23_456_7890_1234567_4_54; // Los guiones no tienen orden especial


Para decimales, es necesario utilizar un sufijo


* float = 3.141_159_265F; // Float debe llevar f o F
* double = 3.141_159_265; // Double puede no llevar sufijo
* double doubleVal2 = 3.141_159_265D; // o se puede utilizar D o d
* decimal decimalVal = 3.141_159_265M; // Decimal debe llevar M o m


Se puede utilizar notación científica/exponencial para facilitar la lectura


* float floatValExp = 8.148_484_599e12F; // e o E denota notación cientifica
* double doubleValExp = 8.148_484_599E-12; // e o E soporta valores negativos


Existen constantes para los valores mínimos y máximos de los tipos de dato numéricos


* sbyte sbyteMin = sbyte.MinValue; // -128
* double doubleMax = double.MaxValue; // 1.79769E+


Existen una variable para valores implícitos que no necesitan especificarse
* var name


### Obtener tipo de dato
* variable.GetType()
- byte --> System.Byte
- int --> System.Int32
- float --> System.Single


```casharp
sbyte SbyteValue = 1;


Console.WriteLine("SByteValue.GetType());
```




### Texto
* string: cadenas de texto (" ")


#### Métodos de las cadenas
* Length --> Longitud de la cadena (No lleva paréntesis)
* Contains() --> Verifica si una cadena contiene a otra
* EndsWith(cadena_a_comparar) --> Verifica si una cadena termina con otra
* StartsWith(cadena_a_comparar) --> Verifica si una cadena inicia con otra
* Replace(búsqueda, reemplazo) --> Reemplaza todas las ocurrencias de la cadena de búsqueda por la
  cadena de reemplazo
* Split(separador) --> Regresa un arreglo de cadenas, separadas por el separador
* SubString(inicio) --> Regresa una cadena de caracteres desde el índice indicado hasta el final
* SubString(inicio, fin) --> Regresa una cadena de caracteres desde el índice indicado hasta fin
* ToLower() --> Regresa la cadena con todas las letras en minúsculas
* ToUpper() --> Regresa la cadena con todas las letras en mayúsculas
* Trim() --> Elimina los espacios en blanco al inicio y fin de la cadena


```casharp
string cadena = " Esta es una cadena separada por espacios. ";


// Obtiene la longitud de la cadena
int longitud = cadena.Length;
Console.WriteLine("longitud: " + longitud); // 43 (Los espacios cuentan)


Console.WriteLine();


// Verifica si "Por" existe en la cadena
bool contienePorMayuscula = cadena.Contains("Por");
Console.WriteLine("contiene por mayuscula: " + contienePorMayuscula); // False, es sensible


Console.WriteLine();


// Verifica si "por" existe en la cadena
bool contienePorMinuscula = cadena.Contains("por");
Console.WriteLine("contiene por minúscula: " + contienePorMinuscula); // True, por existe ve


Console.WriteLine();


// Verifica si la cadena termina con un espacio en blanco
bool terminaConEspacio = cadena.EndsWith(" ");
Console.WriteLine("termina con un espacio: " + terminaConEspacio); // True (Termina con un e


Console.WriteLine();


// Verifica si la cadena empieza con la palabra "Esta"
bool comienzaConEsta = cadena.StartsWith("Esta");
Console.WriteLine("comience con la palabra Esta: " + comienzaConEsta); // "na separada por es


Console.WriteLine();


// Separa la cadena en un arreglo de cadenas por espacios
string[] palabras = cadena.Split(' '); // ["Esta", "es", "una", "cadena", "separada", "por"
for (int i = 0; i < palabras.Length; ++i)
{
Console.WriteLine("palabra " + i + ": " + palabras[i]);
}


Console.WriteLine();


// Obtiene la cadena a partir del índice 10
string subcadena = cadena.Substring(10);
Console.WriteLine("subcadena: " + subcadena); // E (El primer carácter es un espacio)


Console.WriteLine();


// Obtiene la cadena a partir del índice 1 hasta el 2
string primerCaracter = cadena.Substring(1, 2);
Console.WriteLine("Primer carácter: " + primerCaracter); // E (El primer carácter es un espa


Console.WriteLine();


// Obtiene la cadena a partir del índice 42 (longitud - 1)
string ultimoCaracter = cadena.Substring(cadena.Length - 2, 1);
Console.WriteLine("Último carácter: " + ultimoCaracter); // . (El último carácter es un espa


Console.WriteLine();


// Reemplaza los espacios por guiones
string espaciosPorGuiones = cadena.Replace(" ", "-");
Console.WriteLine("espacios por guiones: " + espaciosPorGuiones); // "-Esta-es-una-cadena-se


Console.WriteLine();


// Convierte la cadena a minúsculas
string minusculas = cadena.ToLower();
Console.WriteLine("minusculas: " + minusculas); // " esta es una cadena separada por espacio


Console.WriteLine();


// Convierte la cadena a mayúsculas
string mayusculas = cadena.ToUpper();
Console.WriteLine("mayusculas: " + mayusculas); // " ESTA ES UNA CADENA SEPARADA POR ESPACIO


Console.WriteLine();


// Elimina los espacios al inicio y al final
string eliminarEspacioInicoFin = cadena.Trim();
Console.WriteLine("eliminar espacios al inicio y al final: " + eliminarEspacioInicoFin);
```


* char: cadenas de caracteres  (' ')
* bool: true o false


### Operadores para booleanos relacionales
* Igual (==) Determina si dos valores son iguales
* Diferente (!=) Determina si dos valores son diferentes
* Mayor que (>) Determina si un valor es mayor que otro
* Menor que (<) determina si un valor es menor que otro
* Mayor o igual que (>=) Determina si un valor es mayoro igual que otro
* Menor o igual que (<=) Determina si un valor es menor o igual que otro


### Operadores para booleanos lógicos
* Negacion, NOT (!) Convierte un booleano a su negación (!true) = false
* Y, AND (&&) Determina si dos valores son verdaderos (true && true) = true
* O, OR (||) Determina si uno de dos valores es verdadero (true || false) = true

________________________________________________________________________________________

## 6. Conversiones entre tipos de dato, incluyendo parsing
* Parse --> realizar una conversión de cadena a numeros
```casharpe
// De string a entero
string intStr = "123";
int numVal = int.Parse(intStr);


// Genera un error, el valor no se puede convertir
// HOLA → No tiene sentido convertirla a un número
string str = "Hola";
int    strval = int. Parse(str);


// Podemos convertir la entrada del usuario
Console.Write("Dame un número: ");
string input = Console.ReadLine();
float  floatVal = float.Parse(input);
```
* TryParse --> Para convertir cadenas a números


```casharpe
// 1. De string a entero de forma segura
string intStr = "123";


// Usamos "out int runval" para capturar el resultado
if (int. TryParse(intStr, out int numVal)) {
   Console.WriteLine($"Conversión exitosa: (numVal)");
}
else {
   Console.WriteLine("No se pudo convertir a entero");
}


// 2. Manejo seguro de un valor inválido (como "No)
// Esto ya NO genera una excepción que rompa el pri la")
String str = "Hola";
if (int. TryParse(str, out int strval))
   {
       Console.WriteLine($"Conversión exitosas: (strVal)");
   }
   else
   {
       // "Hola" no es un número válido
       Console.WriteLine($"Error '(str)' no es válido");
   }
```
________________________________________________________________________________________

## 7. Condicionales: `if`, `else`, `else if` y `switch`


* If --> El if evalúa una condición booleana. Si es falso, el programa salta ese bloque
* Else --> se coloca después del if, se ejecuta cuando la condición if es falsa

Sintaxis
```casharpe
if (condicion1)
{
 // Bloque de código que se ejecuta si condicion1 es True
}
else if (condicion2)
{
 // Bloque de código que se ejecuta si condicion1 es false and condicion2 es True
}
else
{
 // Bloque de código que se ejecuta si condicion1 es false and condicion2 es False
}

```

```casharpe
// Si la calificacion es aprobatoria o no


Random rnd = new Random();
int calificacion = rnd.Next(0,10);
Console.WriteLine(calificacion);
if (calificacion > 5) {Console.WriteLine("es aprobatoria");}
else {Console.WriteLine("no es aprobatoria");}




Console.Write("\n\n");


Console.Write("Ingresa un número: ");
int numero = int.Parse(Console.ReadLine());


Console.WriteLine("El número que ingresaste es: " + numero);


if (calificacion > 5) {Console.WriteLine("es aprobatoria");}
else {Console.WriteLine("no es aprobatoria");}
```

Ejemplo 2
```casharpe
// Programa que pida 1 entero y imprima la vida de un jugador


Console.WriteLine("Dame su vida");
int vidaJugador  = int.Parse(Console.ReadLine());


// Programa pide el nombre y apodo del jugador
Console.WriteLine("Dame el nombre");
String nombre  = Console.ReadLine();


Console.WriteLine("Dame el apodo");
String apodo  = Console.ReadLine();


//Pedir MP
int mana;
Console.WriteLine("Dame su MP");
var manaStr = Console.ReadLine();
//validar que sea entero
bool manaValido = int.TryParse(manaStr, out mana);
//mostrar tabla, sino mostrar error
if (manaValido == true)
{
   Console.Write("Nombre: " + nombre);
   Console.WriteLine(" \" " + apodo + " \" ");
   Console.WriteLine("HP: " + vidaJugador);
   Console.WriteLine("MP: " + mana);
}


else {Console.WriteLine("error");}
```
* else if --> Sirve para comprobar una nueva condición en secuencia si la primera condición del if fue falsa


```casharp
int calificacion = 8;
if (calificacion == 10) {
Console.WriteLine("Excelente.");
} else if (calificacion >= 7) {
Console.WriteLine("Aprobado.");
} else {
Console.WriteLine("Reprobado.");
}
```


* switch --> Permite seleccionar una acción entre múltiples alternativas concretas de un mismo valor
- case --> un posible valor
- break --> Termina ese caso
- default --> Ningún caso coincide

Sintaxis
```casharp
switch(expression)
{
 case x:
 // Bloque de código
 break;
 case y:
 // Bloque de código
 break;
 default:
 // Bloque de código
 break;
}

```

Ejemplo
```casharp
int opcion = 1;
switch (opcion)
{
   case 1:
       Console.WriteLine("Nueva partida");
       break;
   case 2:
       Console.WriteLine("Cargar partida");
       break;
   default:
       Console.WriteLine("Opción inválida");
       break;
}
```
- es posible combinar casos


Sintaxis
```casharp
switch (opcion) {
case OPCION1:
   case OPCION1:
   // Se ejecuta para opción 1
       break;
   case OPCION2:
   case OPCION3:
   // Se ejecuta para opción 2 o para opción 3 
       break;
   default:
   // Se ejecuta para cualquier otra opción 
       break;
      
```
Ejemplo
```casharp     
      
char calificacion = 'B';
switch (calificacion)
{
   case 'A':
       Console.WriteLine(" ¡Excelente!");
       break;
   case 'B':
   case 'C':
       Console.WriteLine("Aprobado con buen nivel.' break");
   case 'D':
   case 'F':
       Console.WriteLine("Reprobado o en riesgo.");
       break;
   default:
       Console.WriteLine("Calificación no válida.");
       break;
}
```
________________________________________________________________________________________

## 8. Ciclos


* while --> repite un bloque de código mientras la condición sea verdadera
* número de iteraciones 0 - N veces
* Revisa la condición: Antes de cada iteracion


Sintaxis
```casharp
while (condicion) {
   // codigo a ejecutarse
   // mientras se cumple
   // la condición
}
```
Ejemplo
```casharp     
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
   Console.WriteLine("Vida del enemigo después del ataque: " + vida);
   Console.WriteLine("\n");
}
```


* DO-While --> Repite un bloque de código mientras la condición sea verdadera
    * número de iteraciones 1 - N veces
    * Revisa la condición: Después de cada iteración


Sintaxis
```casharp
do {
   // código a ejecutarse
   // al menos una vez
   // y mientras se
   // cumpla la condición
} while (condicion);
```
Ejemplo
```casharp     
//E2 - Genera un programa que pida un numero entero hasta encontrar el correcto


string num;
bool   si;
int    numINT;
int    numCorrecto = 5;


do
{
   Console.WriteLine("Dame un numero entero");
   num = Console.ReadLine();
   si = int.TryParse(num, out numINT);
   if (si == true)
   {
       if (numINT == numCorrecto)
       {
           Console.WriteLine("Numero correcto");
       }
       else
       {
           Console.WriteLine("Numero incorrecto, dame otro número entero");
       }
   }
   else
   {
       Console.WriteLine("Dato no válido ");
   }


} while (numCorrecto != numINT);
```


* For --> repite un bloque de código mientras la condición sea verdadera
    * número de iteraciones 0 - N veces
    * Revisa la condición: Antes de cada iteración
    * La inicializacion, condicion y el cambio forman parte de la sintaxis


Sintaxis
```casharp
while (inicio; condicion; cambio;) {
   // código a ejecutarse
   // mientras se cumpla
   // la condición
}
```
Ejemplo
```casharp     
//E3 - Genera un programa que multiplique la tabla del 7 hasta el 100


var seven = 7;
for (int tabla = 0;
    tabla <= 100;
    tabla++)
{
   Console.WriteLine(seven + " * " + tabla + " = " + tabla * 7);


}
```

* Break y Continue --> Permiten salir o continuar un ciclo

Ejemplo
```casharp
for (int i = 0; i < 10; i++)
{
     if (i == 4)
     {
     continue; // Cuando llega aquí, el ciclo se reinicia, ignorando el código de la iteració
     }
         if (i == 8)
         {
         break; // Cuando llega aquí, el ciclo se rompe y termina
         }
     Console.WriteLine(i);
}
// Imprime 0, 1, 2, 3, 5, 6 y 7, separados por salto de línea
// Omite el 4 por ser un continue y para al llegar al 8 (break)

```

________________________________________________________________________________________

## 9. Arreglos
[ Arreglos Guia]([texto](https://drive.google.com/file/d/1tdg-LGUZC-kQIld2LdI13LaX1VVOIgLS/view))


Un arreglo (array) es una estructura que permite almacenar múltiples valores del mismo tipo bajo un
solo nombre. Cada valor se guarda en una posición identificada por un índice numérico.

* Un arreglo guarda muchos valores del mismo tipo.


* Usa variables -->  cuando solo necesitas un valor individual.
* Usa arreglos 1D --> cuando necesitas varios valores del mismo tipo.
* Usa 2D cuando --> tus datos tienen forma de tabla o mapa.
* Usa 3D cuando --> representas espacio o estructuras volumétricas.
* Arreglos Jagged (Irregulares) --> es una estantería irregular: cada fila tiene un número diferente de cajas



________________________________________________________________________________________

## 10. Listas
[ Listas Guia]([texto](https://drive.google.com/file/d/1eVRmnJ_BeLmfcOjMeBdSdBzYiEwrV3uE/view))