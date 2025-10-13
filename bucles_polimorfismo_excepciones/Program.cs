/*Abstracta*/

//var circ = new Circulo();
//circ.Radio = 20;
//var resul_area = circ.Area();
//var resul_perimetro = circ.Perimetro();
//Console.WriteLine($"El área es: {resul_area} y el perímetro es: {resul_perimetro}");

//abstract class Figura
//{
//    public abstract double Area();
//    public abstract double Perimetro();
//}
//class Circulo : Figura
//{
//    public double Radio { get; set; }
//    public override double Area() => Math.PI * Radio * Radio;
//    public override double Perimetro() => 2 * Math.PI * Radio;
//}
/*end abstracta*/
//=========================================================================================================================================
/*Interface*/

//var circ = new Circulo();
//circ.Radio = 20;
//var resul_area = circ.Area();
//var resul_perimetro = circ.Perimetro();
//Console.WriteLine($"El área es: {resul_area} y el perímetro es: {resul_perimetro}, el nuevo radio es: {circ.Add10()}");
//interface IExtracalculations
//{
//  public double Add10();
//}
//interface IFigura
//{
//    public double Area();
//    public double Perimetro();
//}
//class Circulo : IFigura, IExtracalculations
//{
//    public double Radio { get; set; }
//    public double Area() => Math.PI * Radio * Radio;
//    public double Perimetro() => 2 * Math.PI * Radio;
//    public double Add10() {
//        return Radio + 10; 
//    }
//}

/*end interface*/
//=========================================================================================================================================
/*bucles*/
int prev = 0, next = 1, sum;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(prev);
    sum = prev + next;
    prev = next;
    next = sum;
}

/*end bucles*/

/*excepciones*/
try
{
    Console.WriteLine("Numero a dividir:");
    double n = double.Parse(Console.ReadLine());
    Console.WriteLine("Divisor:");
    double divisor = double.Parse(Console.ReadLine());
    if (divisor == 0)
    {
        throw new DivideByZeroException();
    }
    Console.WriteLine($"El resultado es: {n / divisor}");

} catch (DivideByZeroException){
    Console.WriteLine("No se puede dividir entre 0");
}
catch (Exception)
{
    Console.WriteLine("error desconocido");
}


/*end excepciones*/