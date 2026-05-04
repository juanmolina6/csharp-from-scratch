var circulo = new Circulo();

circulo.Radio = 20;
var result_area = circulo.Area();
var result_perimetro = circulo.Perimetro();

Console.WriteLine($"El area es: {result_area} y el perimetro es: {result_perimetro} el nuevo radio es: {circulo.Add10()}");

int prev = 0, next = 1, sum;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(prev);
    sum = prev + next;
    prev = next;
    next = sum;
}

try
{
    Console.WriteLine("Numero a dividir: ");
    double n = double.Parse(Console.ReadLine());
    Console.WriteLine("Divisor: ");
    double divisor = double.Parse(Console.ReadLine());
    if (divisor == 0)
    {
        throw new DivideByZeroException();
    }

    Console.WriteLine($"Resultado: {n / divisor}");
}

catch (DivideByZeroException)
{
    Console.WriteLine("No se puede dividir por cero!");
}
catch (Exception)
{
    Console.WriteLine("Error desconocido.");
}


// abstract class Figura
// {
//     public abstract double Area();
//     public abstract double Perimetro();

// }

interface IExtracalculations
{
    public double Add10();
}

interface IFigura
{
    public double Area();
    public double Perimetro();
}

class Circulo : IFigura, IExtracalculations
{
    public double Radio { get; set; }
    public double Area() => Math.PI * Radio * Radio;
    public double Perimetro() => 2 * Math.PI * Radio;
    public double Add10()
    {
        return Radio + 10;
    }

}