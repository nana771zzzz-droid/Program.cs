// Nathalia cespedes villa 2025-0999
using System;

class Calculadora
{
    public double Sumar(double a, double b) => a + b;
    public double Restar(double a, double b) => a - b;
    public double Multiplicar(double a, double b) => a * b;
    public double Dividir(double a, double b) => b != 0 ? a / b : 0;
    
    public string ValidarAprobacion(double nota)
    {
        return nota >= 70 ? "Aprobado" : "Reprobado";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        bool activo = true;

        while (activo)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("1. Calculadora");
                Console.WriteLine("2. Condicion del Alumno");
                Console.WriteLine("3. Salir");
                Console.Write("Elija una opcion: ");
                string opcionPrincipal = Console.ReadLine();

                if (opcionPrincipal == "3")
                {
                    activo = false;
                    continue;
                }

                if (opcionPrincipal == "1")
                {
                    Console.Clear();
                    Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir");
                    Console.Write("Opcion: ");
                    string op = Console.ReadLine();

                    Console.Write("Primer numero: ");
                    double n1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Segundo numero: ");
                    double n2 = Convert.ToDouble(Console.ReadLine());

                    if (op == "1") Console.WriteLine("Resultado: " + calc.Sumar(n1, n2));
                    else if (op == "2") Console.WriteLine("Resultado: " + calc.Restar(n1, n2));
                    else if (op == "3") Console.WriteLine("Resultado: " + calc.Multiplicar(n1, n2));
                    else if (op == "4") Console.WriteLine("Resultado: " + calc.Dividir(n1, n2));
                    else Console.WriteLine("Opcion invalida.");
                }
                else if (opcionPrincipal == "2")
                {
                    Console.Clear();
                    Console.Write("Ponga la nota obtenida: ");
                    double nota = Convert.ToDouble(Console.ReadLine());

                    if (nota >= 0 && nota <= 100)
                    {
                        Console.WriteLine("El estudiante esta: " + calc.ValidarAprobacion(nota));
                    }
                    else
                    {
                        Console.WriteLine("Nota fuera de rango.");
                    }
                }
                else
                {
                    Console.WriteLine("Opcion invalida.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Digite solo numeros.");
            }

            if (activo)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
