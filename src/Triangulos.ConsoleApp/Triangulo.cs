using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos.ConsoleApp
{
    internal class Triangulo
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Triangulo(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public string VerificarTriangulo()
        {
            if (X < Y + Z && Y < X + Z && Z < X + Y)
            {
                if (X == Y && Y == Z)
                {
                    return "Triângulo Equilátero";
                }
                else if (X == Y || X == Z || Y == Z)
                {
                    return "Triângulo Isósceles";
                }
                else
                {
                    return "Triângulo Escaleno";
                }
            }
            else
            {
                return "Não é um triângulo";
            }
        }
    }
}
