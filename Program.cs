// Nathalia Cespedes
// 2025-0999

bool salir = false;

while (!salir)
{
    Console.Clear();
    Console.WriteLine("--- CALCULADORA ---");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Evaluar estudiante");
    Console.WriteLine("6. Salir");
    Console.Write("\nElija una opcion: ");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Sumar();
            break;
        case "2":
            Restar();
            break;
        case "3":
            Multiplicar();
            break;
        case "4":
            Dividir();
            break;
        case "5":
            EvaluarNotas();
            break;
        case "6":
            salir = true;
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opcion invalida, intente de nuevo.");
            break;
    }

    if (!salir)
    {
        Console.WriteLine("\nPresione ENTER para continuar...");
        Console.ReadLine();
    }
}

void Sumar()
{
    Console.WriteLine("\n-- SUMA --");
    double n1 = PedirNumero("Ingrese primer numero: ");
    double n2 = PedirNumero("Ingrese segundo numero: ");
    Console.WriteLine("Resultado: " + (n1 + n2));
}

void Restar()
{
    Console.WriteLine("\n-- RESTA --");
    double n1 = PedirNumero("Ingrese primer numero: ");
    double n2 = PedirNumero("Ingrese segundo numero: ");
    Console.WriteLine("Resultado: " + (n1 - n2));
}

void Multiplicar()
{
    Console.WriteLine("\n-- MULTIPLICACION --");
    double n1 = PedirNumero("Ingrese primer numero: ");
    double n2 = PedirNumero("Ingrese segundo numero: ");
    Console.WriteLine("Resultado: " + (n1 * n2));
}

void Dividir()
{
    Console.WriteLine("\n-- DIVISION --");
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

void EvaluarNotas()
{
    Console.WriteLine("\n-- NOTAS DEL ESTUDIANTE --");
    double nota1 = PedirNota("Nota 1: ");
    double nota2 = PedirNota("Nota 2: ");
    double nota3 = PedirNota("Nota 3: ");
    double nota4 = PedirNota("Nota 4: ");

    double promedio = (nota1 + nota2 + nota3 + nota4) / 4;
    Console.WriteLine("Promedio final: " + promedio);

    if (promedio >= 70)
    {
        Console.WriteLine("Estado: APROBADO");
    }
    else
    {
        Console.WriteLine("Estado: REPROBADO");
    }
}

double PedirNumero(string mensaje)
{
    double num;
    Console.Write(mensaje);
    while (!double.TryParse(Console.ReadLine(), out num))
    {
        Console.Write("Numero no valido. Digite de nuevo: ");
    }
    return num;
}

double PedirNota(string mensaje)
{
    double nota;
    Console.Write(mensaje);
    while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100)
    {
        Console.Write("Nota invalida (debe ser 0-100). Digite de nuevo: ");
    }
    return nota;
}
