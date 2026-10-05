using System;
using System.Collections.Generic;

namespace MiCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> entradaValores = new List<double>();
            int opcionMenu;
            bool finalizar = false;

            while (!finalizar)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("    CALCULADORA Y CONTROL ACADÉMICO     ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Evaluar Estado del Estudiante");
                Console.WriteLine("6. Salir");
                Console.Write("\nElija una opción (1-6): ");

                if (!int.TryParse(Console.ReadLine(), out opcionMenu))
                {
                    opcionMenu = 0;
                }

                if (opcionMenu >= 1 && opcionMenu <= 4)
                {
                    entradaValores.Clear();

                    entradaValores.Add(PedirNumeroValido("Ingrese el primer número: "));
                    entradaValores.Add(PedirNumeroValido("Ingrese el segundo número: "));

                    string respuestaAdicional;
                    do
                    {
                        Console.Write("\n¿Desea agregar otro número? (S/N): ");
                        respuestaAdicional = (Console.ReadLine() ?? "").Trim().ToUpper();

                        if (respuestaAdicional == "S")
                        {
                            entradaValores.Add(PedirNumeroValido("Ingrese el siguiente número: "));
                        }

                    } while (respuestaAdicional != "N");
                }

                switch (opcionMenu)
                {
                    case 1:
                        double sumaTotal = 0;
                        foreach (double n in entradaValores)
                        {
                            sumaTotal += n;
                        }
                        Console.WriteLine($"\nEl resultado de la suma es: {sumaTotal}");
                        break;

                    case 2:
                        double restaTotal = entradaValores[0];
                        for (int i = 1; i < entradaValores.Count; i++)
                        {
                            restaTotal -= entradaValores[i];
                        }
                        Console.WriteLine($"\nEl resultado de la resta es: {restaTotal}");
                        break;

                    case 3:
                        double productoTotal = 1;
                        foreach (double n in entradaValores)
                        {
                            productoTotal *= n;
                        }
                        Console.WriteLine($"\nEl resultado de la multiplicación es: {productoTotal}");
                        break;

                    case 4:
                        bool errorDivision = false;
                        double cociente = entradaValores[0];

                        for (int i = 1; i < entradaValores.Count; i++)
                        {
                            if (entradaValores[i] == 0)
                            {
                                errorDivision = true;
                                break;
                            }
                            cociente /= entradaValores[i];
                        }

                        if (errorDivision)
                        {
                            Console.WriteLine("\nError: No se puede dividir entre cero.");
                        }
                        else
                        {
                            Console.WriteLine($"\nEl resultado de la división es: {cociente}");
                        }
                        break;

                    case 5:
                        double calificacion = PedirNumeroValido("\nIngrese la nota del estudiante (0 - 100): ");

                        while (calificacion < 0 || calificacion > 100)
                        {
                            Console.WriteLine("Nota fuera de rango. Debe ser entre 0 y 100.");
                            calificacion = PedirNumeroValido("Ingrese la nota nuevamente: ");
                        }

                        if (calificacion >= 70)
                        {
                            Console.WriteLine($"\nEstado: APROBADO (Calificación: {calificacion})");
                        }
                        else
                        {
                            Console.WriteLine($"\nEstado: REPROBADO (Calificación: {calificacion})");
                        }
                        break;

                    case 6:
                        finalizar = true;
                        Console.WriteLine("\nPrograma finalizado correctamente.");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                        break;
                }

                if (!finalizar)
                {
                    Console.Write("\n¿Desea realizar otra operación? (S/N): ");
                    string decision = (Console.ReadLine() ?? "").Trim().ToUpper();

                    if (decision == "N")
                    {
                        finalizar = true;
                        Console.WriteLine("\nGracias por usar el programa.");
                    }
                }
            }

            Console.WriteLine("\nPresione cualquier tecla para cerrar...");
            Console.ReadKey();
        }

        static double PedirNumeroValido(string mensaje)
        {
            double num;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Entrada inválida. Por favor ingrese un número: ");
            }
            return num;
        }
    }
}