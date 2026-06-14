

int opcion;
double num1, num2, resultado;
double nota;
bool activo = true;
// Nathalia cespedes villa 2025-0999
while (activo)
{
    try
    {
        Console.Clear();
        Console.WriteLine("=== MENU PRINCIPAL ===");
        Console.WriteLine("1. Calculadora Basica");
        Console.WriteLine("2. Condicion del Alumno");
        Console.WriteLine("3. Salir");
        Console.Write("\nSeleccione una opcion: ");
        
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("--- CALCULADORA BASICA ---");
                Console.Write("Ingrese el primer numero: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("\nResultados:");
                Console.WriteLine($"Suma: {num1} + {num2} = {num1 + num2}");
                Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
                Console.WriteLine($"Multiplicacion: {num1} * {num2} = {num1 * num2}");
                
                if (num2 != 0)
                {
                    Console.WriteLine($"Division: {num1} / {num2} = {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Division: No se puede dividir entre cero.");
                }
                break;

            case 2:
                Console.Clear();
                Console.WriteLine("--- CONDICION DEL ALUMNO ---");
                Console.Write("Ingrese la nota final del estudiante (0-100): ");
                nota = double.Parse(Console.ReadLine());

                if (nota >= 70)
                {
                    Console.WriteLine("\nEstado: APROBADO");
                }
                else
                {
                    Console.WriteLine("\nEstado: REPROBADO");
                }
                break;

            case 3:
                activo = false;
                Console.WriteLine("\nSaliendo del programa...");
                break;

            default:
                Console.WriteLine("\nOpcion no valida. Intente de nuevo.");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("\nError: Debe ingresar un numero valido.");
    }

    if (activo)
    {
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}
