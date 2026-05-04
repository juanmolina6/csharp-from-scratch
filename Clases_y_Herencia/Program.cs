//var rectangulo = new Rectangulo();
//rectangulo.Base = 20;
//rectangulo.Altura = 40;
//Console.WriteLine($"El area es: {rectangulo.Area()}");
//Console.WriteLine($"El perimetro es: {rectangulo.Perimetro()}");

var cuadrado= new Cuadrado();
cuadrado.Base = 50;
cuadrado.Altura = 100;
Console.WriteLine($"El area es: {cuadrado.Area()}");
Console.WriteLine($"El perimetro es: {cuadrado.Perimetro()}");
Console.WriteLine($"El Lado es: {cuadrado.Lado}");
class Rectangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public double Area() => Base * Altura;

    public double Perimetro() => 2 * Base + 2 * Altura;

}

class Cuadrado : Rectangulo
{
    public double Lado
    {
        set { Base = value; Altura = value; }
        get { return Base; }
    }

}
