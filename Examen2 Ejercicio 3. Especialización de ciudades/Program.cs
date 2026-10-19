// EQUIPO3_INTEGRANTE_1_JORGE JAVIER GARCIA MORENO_INTEGRANTE_2_CARLOS IVAN VÁZQUEZ ACEVEDO
// Problema: Genera un programa que registre la producción de madera, piedra y oro de varias ciudades e identifique cuál produce más de cada recurso
// Objetivo: Identificar la ciudad con mayor producción de cada recurso, mostrando su número y la cantidad producida
// Entradas: Cantidad de ciudades y producción de madera, piedra y oro de cada una
// Salidas: Número de la ciudad que más produce madera, piedra y oro y la cantidad producida de cada recurso



Console.WriteLine("Gestor de produccion de ciudades");

// 1. Pedir cantidad de ciudades

    Console.WriteLine("Dame la cantidad de ciudades");
    int totalCiudades = int.Parse(Console.ReadLine());

    // Variables para guardar los maximos
    int maxMadera = 0;
    int maxPiedra = 0;
    int maxOro    = 0;

    // Se comienza en 1 para saltarnos el 0 de indice, y inicie en 1
    int ciudadMadera = 1;
    int ciudadPiedra = 1;
    int ciudadOro    = 1;

// 2. Registrar y comparar la producción
    for (int i = 1; i <= totalCiudades; i++)
    {
        Console.WriteLine("\nCiudad " + i);

        Console.Write("Produccion de madera: ");
        int madera = int.Parse(Console.ReadLine());

        Console.Write("Produccion de piedra: ");
        int piedra = int.Parse(Console.ReadLine());

        Console.Write("Produccion de oro: ");
        int oro = int.Parse(Console.ReadLine());

        // guardar los datos de la primera ciudad
        if (i == 1)
        {
            maxMadera = madera;
            maxPiedra = piedra;
            maxOro    = oro;
        }
        else
        {
            // si hay uno mayor a la primera ciudad, se actializa el maximo y se guarda el indice de la ciudad
            // mayor produccion de madera
            if (madera > maxMadera)
            {
                maxMadera    = madera;
                ciudadMadera = i;
            }

            // mayor produccion de piedra
            if (piedra > maxPiedra)
            {
                maxPiedra    = piedra;
                ciudadPiedra = i;
            }

            // mayor produccion de oro
            if (oro > maxOro)
            {
                maxOro    = oro;
                ciudadOro = i;
            }
        }
    }

    // 3. Mostrar los resultados
    Console.WriteLine("\nResultados");

    Console.WriteLine("Madera:");
    Console.WriteLine("Ciudad: " + ciudadMadera);
    Console.WriteLine("Produccion: " + maxMadera);

    Console.WriteLine("\nPiedra:");
    Console.WriteLine("Ciudad: " + ciudadPiedra);
    Console.WriteLine("Produccion: " + maxPiedra);

    Console.WriteLine("\nOro:");
    Console.WriteLine("Ciudad: " + ciudadOro);
    Console.WriteLine("Produccion: " + maxOro);


