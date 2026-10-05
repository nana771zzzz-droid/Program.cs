using System;

namespace ProyectoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finalizar = false;

            while (!finalizar)
            {
                Console.Clear();
                Console.WriteLine("--- CALCULADORA C# ---");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Promedio de Notas");
                Console.WriteLine("6. Salir");
                Console.Write("\nSeleccione una opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        HacerSuma();
                        break;
                    case "2":
                        HacerResta();
                        break;
                    case "3":
                        HacerMultiplicacion();
                        break;
                    case "4":
                        HacerDivision();
                        break;
                    case "5":
                        CalcularNotas();
                        break;
                    case "6":
                        finalizar = true;
                        Console.WriteLine("\nSaliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpcion no valida. Presione Enter para intentar de nuevo.");
                        Console.ReadLine();
                        break;
                }

                if (!finalizar && opcion != "6")
                {
                    Console.WriteLine("\nPresione Enter para volver al menu.");
                    Console.ReadLine();
                }
            }
        }

        static void HacerSuma()
        {
            Console.WriteLine("\n-- Suma --");
            double n1 = PedirNumero("Ingrese primer numero: ");
            double n2 = PedirNumero("Ingrese segundo numero: ");
            Console.WriteLine("Resultado: " + (n1 + n2));
        }

        static void HacerResta()
        {
            Console.WriteLine("\n-- Resta --");
            double n1 = PedirNumero("Ingrese primer numero: ");
            double n2 = PedirNumero("Ingrese segundo numero: ");
            Console.WriteLine("Resultado: " + (n1 - n2));
        }

        static void HacerMultiplicacion()
        {
            Console.WriteLine("\n-- Multiplicacion --");
            double n1 = PedirNumero("Ingrese primer numero: ");
            double n2 = PedirNumero("Ingrese segundo numero: ");
            Console.WriteLine("Resultado: " + (n1 * n2));
        }

        static void HacerDivision()
        {
            Console.WriteLine("\n-- Division --");
            double n1 = PedirNumero("Ingrese primer numero: ");
            double n2 = PedirNumero("Ingrese segundo numero: ");

            if (n2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }
            else
            {
                Console.WriteLine("Resultado: " + (n1 / n2));
            }
        }

        static void CalcularNotas()
        {
            Console.WriteLine("\n-- Control de Notas --");
            double n1 = PedirNota("Nota 1: ");
            double n2 = PedirNota("Nota 2: ");
            double n3 = PedirNota("Nota 3: ");
            double n4 = PedirNota("Nota 4: ");

            double promedio = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine("\nPromedio final: " + promedio);

            if (promedio >= 70)
            {
                Console.WriteLine("Estado: Aprobado");
            }
            else
            {
                Console.WriteLine("Estado: Reprobado");
            }
        }

        static double PedirNumero(string mensaje)
        {
            double num;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Entrada invalida. Intente de nuevo: ");
            }
            return num;
        }

        static double PedirNota(string mensaje)
        {
            double nota;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100)
            {
                Console.Write("Nota invalida (0 a 100). Intente de nuevo: ");
            }
            return nota;
        }
    }
}
