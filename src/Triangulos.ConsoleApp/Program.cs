namespace Triangulos.ConsoleApp

    // Dados três valores X, Y, Z, verifiquem se eles podem ser os comprimentos dos lados de um triângulo e se forem escrever uma mensagem informando se é um triângulo eqüilátero, isósceles ou escaleno.
    // Observações:
    // O comprimento de um lado do triângulo é sempre menor do que a soma dos outros dois.
    // Eqüilátero: Todos os lados iguais
    // Isósceles: Dois lados iguais
    // Escaleno: Todos os lados diferentes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Mensagem de boas vindas
            Console.WriteLine("Bem-vindo ao verificador de triângulos!");
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();

            // Solicitação de dados

            Console.WriteLine("Digite o valor de X: ");
            int x = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor de Y: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de Z: ");
            int z = int.Parse(Console.ReadLine());


            // Verificação de triângulo
            Console.WriteLine();
            if (x < y + z && y < x + z && z < x + y)
            {
                if (x == y && y == z)
                {
                    Console.WriteLine("Triângulo Equilátero");
                }
                else if (x == y || x == z || y == z)
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Não é um triângulo");
            }
            
            Console.ReadKey();




        }
    }
}
