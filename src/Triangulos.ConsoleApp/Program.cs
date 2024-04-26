namespace Triangulos.ConsoleApp;

// Dados três valores X, Y, Z, verifiquem se eles podem ser os comprimentos dos lados de um triângulo e se forem escrever uma mensagem informando se é um triângulo eqüilátero, isósceles ou escaleno.
// Observações:
// O comprimento de um lado do triângulo é sempre menor do que a soma dos outros dois.
// Eqüilátero: Todos os lados iguais
// Isósceles: Dois lados iguais
// Escaleno: Todos os lados diferentes

internal class Program
{
    private static void Main(string[] args)
    {
        var triangulo1 = new Triangulo.Triangulo(3, 3, 3);
        triangulo1.X = 3;
        triangulo1.Y = 3;
        triangulo1.Z = 3;

        Console.WriteLine(triangulo1.VerificarTriangulo());

        var triangulo2 = new Triangulo.Triangulo(3, 3, 4);
        triangulo2.X = 3;
        triangulo2.Y = 3;
        triangulo2.Z = 4;

        Console.WriteLine(triangulo2.VerificarTriangulo());

        var triangulo3 = new Triangulo.Triangulo(3, 4, 5);
        triangulo3.X = 3;
        triangulo3.Y = 4;
        triangulo3.Z = 5;

        Console.WriteLine(triangulo3.VerificarTriangulo());

        var triangulo4 = new Triangulo.Triangulo(3, 4, 8);
        triangulo4.X = 3;
        triangulo4.Y = 4;
        triangulo4.Z = 8;

        Console.WriteLine(triangulo4.VerificarTriangulo());

        Console.ReadKey();
    }
}