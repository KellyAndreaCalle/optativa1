public class Taller
{
    
    public static void Main(string[] args)
    {
        // Bucle principal para mantener el menu hasta que haya una opcion seleccionada 
        while (true)
        {            
            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine(" Taller Optativa 1 ");
            Console.WriteLine("======================================");
            Console.WriteLine("Seleccione el ejercicio a ejecutar:");
            Console.WriteLine("1. Positive Power");
            Console.WriteLine("2. Double or Triple");
            Console.WriteLine("3. Root or Square");
            Console.WriteLine("4. Circle Perimeter");
            Console.WriteLine("5. Midweek Day");
            Console.WriteLine("6. Tax Calculator");
            Console.WriteLine("7. Remainder Finder");
            Console.WriteLine("8. Sum of Evens");
            Console.WriteLine("9. Fraction Difference");
            Console.WriteLine("10. String Length");
            Console.WriteLine("11. Average of Four");
            Console.WriteLine("12. Smallest of Five");
            Console.WriteLine("13. Vowel Counter");
            Console.WriteLine("14. Factorial Finder");
            Console.WriteLine("15. InRange Validator");
            Console.WriteLine("0. Salir");
            Console.WriteLine("======================================");

            // Se captura el valor que digita el usuario y se manjea mediante un try catch por si se presentan excepciones
            try
            {
                Console.Write("Ingrese su opcion: ");
                int opcion = int.Parse(Console.ReadLine());

                // Se utiliza un switch case para poder ejecutar el ejercicio que corresponda segun la seleccion del usuario
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Muchas gracias, hasta luego!");
                        return; 
                    case 1:
                        PositivePower();
                        break;
                    case 2:
                        DoubleOrTriple();
                        break;
                    case 3:
                        RootOrSquare();
                        break;
                    case 4:
                        CirclePerimeter();
                        break;
                    case 5:
                        MidweekDay();
                        break;
                    case 6:
                        TaxCalculator();
                        break;
                    case 7:
                        RemainderFinder();
                        break;
                    case 8:
                        SumOfEvens();
                        break;
                    case 9:
                        FractionDifference();
                        break;
                    case 10:
                        StringLength();
                        break;
                    case 11:
                        AverageOfFour();
                        break;
                    case 12:
                        SmallestOfFive();
                        break;
                    case 13:
                        VowelCounter();
                        break;
                    case 14:
                        FactorialFinder();
                        break;
                    case 15:
                        InRangeValidator();
                        break;
                    default:
                        Console.WriteLine("Opcion no válida. Intente de nuevo.");
                        break;
                }
            }
            // aqui damos manejo a las excepciones segun como lo trabajamos en clase y a lo largo de las ramas del repositorio
            catch (FormatException)
            {
                Console.WriteLine("Error: Debe ingresar un numero válido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error inesperado: {ex.Message}");
            }
            // pausa para que el usuario pueda ver el resultado antes de volver al menu.
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
    // Metodos para el desarrollo de los ejercicios
    // 1. Positive Power
    private static void PositivePower()
    {
        Console.WriteLine("\n--- 1. Positive Power ---");
        Console.Write("Ingrese un numero: ");
        double num = double.Parse(Console.ReadLine());
        if (num > 0)
        {
            
            Console.WriteLine($"Resultado: {Math.Pow(num, 2)}");
        }
        else if (num < 0)
        {
            Console.WriteLine("Resultado: Numero negativo.");
        }
        else
        {
            Console.WriteLine("Resultado: 0");
        }
    }
    // 2. Double or Triple
    private static void DoubleOrTriple()
    {
        Console.WriteLine("\n--- 2. Double or Triple ---");
        Console.Write("Ingrese el primer numero: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        double num2 = double.Parse(Console.ReadLine());
        if (num1 > num2)
        {
            Console.WriteLine($"Resultado: {num1 * 2}");
        }
        else
        {
            Console.WriteLine($"Resultado: {num2 * 3}");
        }
    }
    // 3. Root or Square
    private static void RootOrSquare()
    {
        Console.WriteLine("\n--- 3. Root or Square ---");
        Console.Write("Ingrese un numero: ");
        double num = double.Parse(Console.ReadLine());
        if (num >= 0)
        {
            Console.WriteLine($"Resultado: {Math.Sqrt(num)}");
        }
        else
        {
            Console.WriteLine($"Resultado: {Math.Pow(num, 2)}");
        }
    }
    // 4. Circle Perimeter
    private static void CirclePerimeter()
    {
        Console.WriteLine("\n--- 4. Circle Perimeter ---");
        Console.Write("Ingrese el radio del circulo: ");
        double radio = double.Parse(Console.ReadLine());
        double perimetro = 2 * Math.PI * radio;
        Console.WriteLine($"Resultado: {perimetro}"); 
    }
    // 5. Midweek Day
    private static void MidweekDay()
    {
        Console.WriteLine("\n--- 5. Midweek Day ---");
        Console.Write("Ingrese un numero del 1 al 7: ");
        int dia = int.Parse(Console.ReadLine());
        string resultado;
        switch (dia)
        {
            case 1: resultado = "Lunes"; break;
            case 2: resultado = "Martes"; break;
            case 3: resultado = "Miercoles"; break;
            case 4: resultado = "Jueves"; break;
            case 5: resultado = "Viernes"; break;
            default: resultado = "Numero fuera del rango laboral."; break;
        }
        Console.WriteLine($"Resultado: {resultado}");
    }
    // 6. Tax Calculator
    private static void TaxCalculator()
    {
        Console.WriteLine("\n--- 6. Tax Calculator ---");
        Console.Write("Ingrese su salario anual: ");
        double salario = double.Parse(Console.ReadLine());
        if (salario > 12000)
        {
            double excedente = salario - 12000;
            double impuesto = excedente * 0.15;
            Console.WriteLine($"Resultado: {impuesto}");
        }
        else
        {
            Console.WriteLine("Resultado: No debe impuestos.");
        }
    }
    // 7. Remainder Finder
    private static void RemainderFinder()
    {
        Console.WriteLine("\n--- 7. Remainder Finder ---");
        Console.Write("Ingrese el dividendo: ");
        int dividendo = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el divisor: ");
        int divisor = int.Parse(Console.ReadLine());
        if (divisor == 0)
        {
             Console.WriteLine("Error: No se puede dividir entre 0.");
        } else {
             int residuo = dividendo % divisor;
             Console.WriteLine($"Resultado: {residuo}");
        }
    }
    // 8. Sum of Evens
    private static void SumOfEvens()
    {
        Console.WriteLine("\n--- 8. Sum of Evens ---");
        int suma = 0;
        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 == 0) // Si es par
            {
                suma += i; // Lo añade a la suma
            }
        }
        Console.WriteLine($"Resultado: {suma}");
    }
    // 9. Fraction Difference
    private static void FractionDifference()
    {
        Console.WriteLine("\n--- 9. Fraction Difference ---");
        Console.WriteLine("Ingrese la primera fraccion (ej. 1/2):");
        string[] fraccion1Str = Console.ReadLine().Split('/');
        Console.WriteLine("Ingrese la segunda fraccion (ej. 1/3):");
        string[] fraccion2Str = Console.ReadLine().Split('/');
        int num1 = int.Parse(fraccion1Str[0]);
        int den1 = int.Parse(fraccion1Str[1]);
        int num2 = int.Parse(fraccion2Str[0]);
        int den2 = int.Parse(fraccion2Str[1]);
        int nuevoNum = (num1 * den2) - (num2 * den1);
        int nuevoDen = den1 * den2;
        Console.WriteLine($"Resultado: {nuevoNum}/{nuevoDen}");
    }
    // 10. String Length
    private static void StringLength()
    {
        Console.WriteLine("\n--- 10. String Length ---");
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();
        Console.WriteLine($"Resultado: {palabra.Length}");
    }
    // 11. Average of Four
    private static void AverageOfFour()
    {
        Console.WriteLine("\n--- 11. Average of Four ---");
        Console.Write("Ingrese el primer numero: ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        double n2 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el tercer numero: ");
        double n3 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el cuarto numero: ");
        double n4 = double.Parse(Console.ReadLine());

        double promedio = (n1 + n2 + n3 + n4) / 4;
        Console.WriteLine($"Resultado: {promedio}");
    }
    // 12. Smallest of Five
    private static void SmallestOfFive()
    {
        Console.WriteLine("\n--- 12. Smallest of Five ---");
        double[] numeros = new double[5];
        for(int i = 0; i < 5; i++)
        {
            Console.Write($"Ingrese el numero {i+1}: ");
            numeros[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Resultado: {numeros.Min()}");
    }
    // 13. Vowel Counter
    private static void VowelCounter()
    {
        Console.WriteLine("\n--- 13. Vowel Counter ---");
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower(); // se convertimos a minusculas 
        char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
        int contador = 0;
        foreach (char letra in palabra)
        {
            if (vocales.Contains(letra))
            {
                contador++;
            }
        }
        Console.WriteLine($"Resultado: {contador}");
    }
    // 14. Factorial Finder
    private static void FactorialFinder()
    {
        Console.WriteLine("\n--- 14. Factorial Finder ---");
        Console.Write("Ingrese un numero: ");
        int num = int.Parse(Console.ReadLine());
        long factorial = 1;    
        for (int i = num; i > 1; i--)
        {
            factorial *= i;
        }
        Console.WriteLine($"Resultado: {factorial}");
    }
    // 15. InRange Validator
    private static void InRangeValidator()
    {
        Console.WriteLine("\n--- 15. InRange Validator ---");
        Console.Write("Ingrese un numero: ");
        int num = int.Parse(Console.ReadLine());   
        if (num >= 10 && num <= 20)
        {
            Console.WriteLine("Resultado: Esta en el rango.");
        }
        else
        {
            Console.WriteLine("Resultado: Fuera del rango.");
        }
    }
}