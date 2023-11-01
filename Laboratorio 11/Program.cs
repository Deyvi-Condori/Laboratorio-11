using System;

class Program
{
    static void Main()
    {
        string[] notas = new string[100]; 
        int cantidadNotas = 0; 

        while (true)
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Casos con arreglos");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar notas");
            Console.WriteLine("2: Hallar la nota mayor");
            Console.WriteLine("3: Hallar la nota menor");
            Console.WriteLine("4: Encontrar una nota");
            Console.WriteLine("5: Modificar una nota");
            Console.WriteLine("6: Ver notas registradas");
            Console.WriteLine("7: Salir");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        RegistrarNotas(notas, ref cantidadNotas);
                        break;
                    case 2:
                        HallarNotaMayor(notas, cantidadNotas);
                        break;
                    case 3:
                        HallarNotaMenor(notas, cantidadNotas);
                        break;
                    case 4:
                        EncontrarNota(notas, cantidadNotas);
                        break;
                    case 5:
                        ModificarNota(notas, cantidadNotas);
                        break;
                    case 6:
                        VerNotasRegistradas(notas, cantidadNotas);
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción inválida. Intente nuevamente.");
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void RegistrarNotas(string[] notas, ref int cantidadNotas)
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("Registrar notas");
        Console.WriteLine("================================");

        if (cantidadNotas < notas.Length)
        {
            Console.Write("Ingresa la nota Nro " + (cantidadNotas + 1) + ": ");
            notas[cantidadNotas] = Console.ReadLine();
            cantidadNotas++;

            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar otra nota");
            Console.WriteLine("2: Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                if (opcion == 1)
                {
                    RegistrarNotas(notas, ref cantidadNotas); 
                }
            }
            else if (opcion == 2)
            {
                return;
            }
            else
            {
                Console.WriteLine("Opción inválida. Volviendo al menú principal.");
            }
        }
        else
        {
            Console.WriteLine("Se ha alcanzado el límite de notas.");
            Console.WriteLine("================================");
            Console.WriteLine("1: Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());
        }
    }

    static void HallarNotaMayor(string[] notas, int cantidadNotas)
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("La nota mayor");
        Console.WriteLine("================================");

        if (cantidadNotas > 0)
        {
            int notaMayor = int.Parse(notas[0]);

            for (int i = 1; i < cantidadNotas; i++)
            {
                int notaActual = int.Parse(notas[i]);
                if (notaActual > notaMayor)
                {
                    notaMayor = notaActual;
                }
            }

            Console.WriteLine("La nota mayor es: " + notaMayor);
            for (int i = 0; i < cantidadNotas; i++)
            {
                if (i > 0)
                {
                    Console.Write(" ");
                }

                if (int.Parse(notas[i]) == notaMayor)
                {
                    Console.Write("[" + notas[i] + "]");
                }
                else
                {
                    Console.Write(notas[i]);
                }
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No hay notas registradas.");
        }

        Console.WriteLine("================================");
        Console.WriteLine("1: Regresar");
        Console.WriteLine("================================");
        Console.Write("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            return;
        }
    }

    static void HallarNotaMenor(string[] notas, int cantidadNotas)
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("La nota menor");
        Console.WriteLine("================================");

        if (cantidadNotas > 0)
        {
            int notaMenor = int.Parse(notas[0]);
            int posicionMenor = 0;

            for (int i = 1; i < cantidadNotas; i++)
            {
                int notaActual = int.Parse(notas[i]);
                if (notaActual < notaMenor)
                {
                    notaMenor = notaActual;
                    posicionMenor = i;
                }
            }

            Console.WriteLine("La nota menor es: " + notaMenor);

            for (int i = 0; i < cantidadNotas; i++)
            {
                if (i > 0)
                {
                    Console.Write(" ");
                }
                if (i == posicionMenor)
                {
                    Console.Write("[" + notaMenor + "]");
                }
                else
                {
                    Console.Write(notas[i]);
                }
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No hay notas registradas.");
        }

        Console.WriteLine("================================");
        Console.WriteLine("1: Regresar");
        Console.WriteLine("================================");
        Console.Write("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            return;
        }
    }

    static void EncontrarNota(string[] notas, int cantidadNotas)
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("Buscar nota");
        Console.WriteLine("================================");
        Console.Write("Ingrese la nota a buscar: ");
        int notaBuscar = int.Parse(Console.ReadLine());

        int posicionEncontrada = -1;

        Console.WriteLine("La nota está en la posición:");

        for (int i = 0; i < cantidadNotas; i++)
        {
            if (int.Parse(notas[i]) == notaBuscar)
            {
                Console.WriteLine(i + " -> [" + notaBuscar + "]");
                posicionEncontrada = i;
            }
            else
            {
                Console.WriteLine(i + " -> " + notas[i]);
            }
        }

        if (posicionEncontrada >= 0)
        {
            Console.WriteLine("================================");
            Console.WriteLine("1: Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                return;
            }
        }
        else
        {
            Console.WriteLine("La nota no se encontró.");
            Console.WriteLine("================================");
            Console.WriteLine("1: Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                return;
            }
        }
    }

    static void ModificarNota(string[] notas, int cantidadNotas)
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("Modificar nota");
        Console.WriteLine("================================");

        if (cantidadNotas > 0)
        {

            Console.Write("Ingrese la posición: ");
            int posicion = int.Parse(Console.ReadLine());

            if (posicion >= 0 && posicion < cantidadNotas)
            {
                Console.Write("Ingrese el nuevo valor: ");
                int nuevoValor = int.Parse(Console.ReadLine());

                Console.WriteLine("================================");
                Console.WriteLine("Antes:");
                MostrarNotasConDestacado(notas, cantidadNotas, posicion); 

                notas[posicion] = nuevoValor.ToString();

                Console.WriteLine("Después:");
                MostrarNotasConDestacado(notas, cantidadNotas, posicion);
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("Posición inválida.");
            }
        }
        else
        {
            Console.WriteLine("No hay notas registradas.");
        }

        Console.WriteLine("================================");
        Console.WriteLine("1: Regresar");
        Console.WriteLine("================================");
        Console.Write("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            return;
        }
    }
    static void MostrarNotasConDestacado(string[] notas, int cantidadNotas, int posicionDestacada)
    {
        for (int i = 0; i < cantidadNotas; i++)
        {
            if (i > 0)
            {
                Console.Write(" ");
            }

            if (i == posicionDestacada)
            {
                Console.Write("[" + notas[i] + "]"); 
            }
            else
            {
                Console.Write(notas[i]);
            }
        }
        Console.WriteLine();
    }

    static void VerNotasRegistradas(string[] notas, int cantidadNotas)
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("Notas Registradas");
        Console.WriteLine("================================");
        Console.WriteLine("Notas actuales:");
        MostrarNotas(notas, cantidadNotas);
        Console.WriteLine("Siguiente posición será: " + cantidadNotas);
        Console.WriteLine("================================");
        Console.WriteLine("1: Regresar");
        Console.WriteLine("================================");
        Console.Write("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            return;
        }
    }

    static void MostrarNotas(string[] notas, int cantidadNotas)
    {
        for (int i = 0; i < cantidadNotas; i++)
        {
            Console.Write(notas[i]);
            if (i < cantidadNotas - 1)
            {
                Console.Write(" - ");
            }
        }
        Console.WriteLine();
    }
}