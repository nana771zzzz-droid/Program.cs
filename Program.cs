using System;

namespace EjercicioCalculadora
{
    class MiPrograma
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== MENU DE OPCIONES ===");
                Console.WriteLine("a) Suma");
                Console.WriteLine("b) Resta");
                Console.WriteLine("c) Multiplicacion");
                Console.WriteLine("d) Division");
                Console.WriteLine("e) Evaluar Notas");
                Console.WriteLine("f) Salir");
                Console.Write("\nElija una opcion: ");

                string seleccion = Console.ReadLine();

                switch (seleccion)
                {
                    case "a":
                    case "1":
                        CalcularSuma();
                        break;
                    case "b":
                    case "2":
                        CalcularResta();
                        break;
                    case "c":
                    case "3":
                        CalcularMultiplicacion();
                        break;
                    case "d":
                    case "4":
                        CalcularDivision();
                        break;
                    case "e":
                    case "5":
                        ProcesarCalificaciones();
                        break;
                    case "f":
                    case "6":
                        salir = true;
                        Console.WriteLine("\nCerrando el sistema...");
                        break;
                    default:
                        Console.WriteLine("\nOpcion no valida.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        static void CalcularSuma()
        {
            Console.WriteLine("\n[ SUMAR ]");
            double valor1 = LeerDato("Valor 1: ");
            double valor2 = LeerDato("Valor 2: ");
            Console.WriteLine("El total es: " + (valor1 + valor2));
        }

        static void CalcularResta()
        {
            Console.WriteLine("\n[ RESTAR ]");
            double valor1 = LeerDato("Valor 1: ");
            double valor2 = LeerDato("Valor 2: ");
            Console.WriteLine("El total es: " + (valor1 - valor2));
        }

        static void CalcularMultiplicacion()
        {
            Console.WriteLine("\n[ MULTIPLICAR ]");
            double valor1 = LeerDato("Valor 1: ");
            double valor2 = LeerDato("Valor 2: ");
            Console.WriteLine("El total es: " + (valor1 * valor2));
        }

        static void CalcularDivision()
        {
            Console.WriteLine("\n[ DIVIDIR ]");
            double valor1 = LeerDato("Valor 1: ");
            double valor2 = LeerDato("Valor 2: ");

            if (valor2 == 0)
            {
                Console.WriteLine("Atencion: No es posible dividir por 0.");
            }
            else
            {
                Console.WriteLine("El total es: " + (valor1 / valor2));
            }
        }

        static void ProcesarCalificaciones()
        {
            Console.WriteLine("\n[ PROMEDIO DE NOTAS ]");
            double c1 = LeerNota("Nota A: ");
            double c2 = LeerNota("Nota B: ");
            double c3 = LeerNota("Nota C: ");
            double c4 = LeerNota("Nota D: ");

            double notaFinal = (c1 + c2 + c3 + c4) / 4.0;
            Console.WriteLine("\nPromedio alcanzado: " + notaFinal);

            if (notaFinal >= 70)
            {
                Console.WriteLine("Resultado: APROBADO");
            }
            else
            {
                Console.WriteLine("Resultado: REPROBADO");
            }
        }

        static double LeerDato(string mensaje)
        {
            double entrada;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out entrada))
            {
                Console.Write("Dato invalido. Intente de nuevo: ");
            }
            return entrada;
        }

        static double LeerNota(string mensaje)
        {
            double calificacion;
            Console.Write(mensaje);
            while (!double.TryParse(Console.ReadLine(), out calificacion) || calificacion < 0 || calificacion > 100)
            {
                Console.Write("Calificacion fuera de rango (0-100). Reintente: ");
            }
            return calificacion;
        }
    }
}
