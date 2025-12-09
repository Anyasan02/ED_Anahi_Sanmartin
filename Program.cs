using System;

// Clase Circulo
public class Circulo
{
    // Propiedad privada para el radio del círculo
    public double Radio { get; set; }

    // Constructor para inicializar el radio
    public Circulo(double radio)
    {
        Radio = radio;
    }

    // Método para calcular el área del círculo
    // El área se calcula usando la fórmula A = π * r^2
    // Devuelve un valor de tipo double
    public double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }

    // Método para calcular el perímetro del círculo
    // El perímetro se calcula usando la fórmula P = 2 * π * r
    // Devuelve un valor de tipo double
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * Radio;
    }
}

// Clase Cuadrado
public class Cuadrado
{
    // Propiedad privada para el lado del cuadrado
    public double Lado { get; set; }

    // Constructor para inicializar el lado
    public Cuadrado(double lado)
    {
        Lado = lado;
    }

    // Método para calcular el área del cuadrado
    // El área se calcula usando la fórmula A = lado^2
    // Devuelve un valor de tipo double
    public double CalcularArea()
    {
        return Lado * Lado;
    }

    // Método para calcular el perímetro del cuadrado
    // El perímetro se calcula usando la fórmula P = 4 * lado
    // Devuelve un valor de tipo double
    public double CalcularPerimetro()
    {
        return 4 * Lado;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de Circulo con un radio de 5
        Circulo circulo = new Circulo(5);
        Console.WriteLine("Área del Círculo: " + circulo.CalcularArea());
        Console.WriteLine("Perímetro del Círculo: " + circulo.CalcularPerimetro());

        // Crear una instancia de Cuadrado con un lado de 4
        Cuadrado cuadrado = new Cuadrado(4);
        Console.WriteLine("Área del Cuadrado: " + cuadrado.CalcularArea());
        Console.WriteLine("Perímetro del Cuadrado: " + cuadrado.CalcularPerimetro());
    }
}
