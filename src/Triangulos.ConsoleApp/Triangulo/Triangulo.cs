namespace Triangulos.ConsoleApp.Triangulo;

public class Triangulo
{
    public Triangulo(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public string VerificarTriangulo()
    {
        if (X < Y + Z && Y < X + Z && Z < X + Y)
        {
            if (X == Y && Y == Z)
                return "Triângulo Equilátero";
            if (X == Y || X == Z || Y == Z)
                return "Triângulo Isósceles";
            return "Triângulo Escaleno";
        }

        return "Não é um triângulo";
    }
}