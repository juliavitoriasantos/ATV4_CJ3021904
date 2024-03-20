namespace ATV4_CJ3021904
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, op;

            Console.WriteLine("Digite o valor de n1: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de n2: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite qual opção você deseja (0=Adição, 1=Subtração, 2=Multiplicação, 3=Divisão): ");
            op = float.Parse(Console.ReadLine());

            switch (op)
            {
                case 0:

                    Console.WriteLine("Adição = {0}", n1 + n2);
                    break;

                case 1:
                    Console.WriteLine("Subtração = {0}", n1 - n2);
                    break;

                case 2:
                    Console.WriteLine("Multiplicação = {0}", n1 * n2);
                    break;

                case 3:
                    Console.WriteLine("Divisão = {0}", n1 / n2);
                    break;
                 
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                    
            }
        }
    }
}
