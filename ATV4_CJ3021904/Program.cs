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
            //1

            int d;

            Console.WriteLine("Digite um número correspondente a um dia da semana: ");
            d = int.Parse(Console.ReadLine());

            switch(d)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;


                case 2:
                    Console.WriteLine("Segunda- feira");
                    break;

                case 3:
                    Console.WriteLine("Terça- feira");
                    break;

                case 4:
                    Console.WriteLine("Quarta- feira");

                    break;
                case 5:
                    Console.WriteLine("Quinta- feira");
                    break;
                case 6:
                    Console.WriteLine("SExta- feira");
                    break;

                case 7:
                    Console.WriteLine("Sábado");
                    break;

                default : Console.WriteLine("Opção inválida");
                    break;
                    
            }
            //2

            float compra, p;

            Console.WriteLine("Digite o valor total de sua compra: ");
            compra = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua forma de pagamento (1-dinhiro, 2-pix, 3-débito, 4-crédito): ");
            p = float.Parse(Console.ReadLine());

            switch (p)
            {
                case 1:
                    Console.WriteLine("Valor a ser pago: R${0}", (compra - ((15 / 100) * compra)));
                    break;

                case 2: Console.WriteLine("Valor a ser pago: R${0} ", (compra - ((10 / 100) * compra)));
                    break;

                case 3: Console.WriteLine("Valor a ser pago: R${0} ", (compra + ((5 / 100) * compra)));
                    break;

                case 4: Console.WriteLine("Valor a ser pago: R${0} ", (compra + ((10 / 100) * compra)));
                    break;

                default: Console.WriteLine("Opção inválida");
                    break;
            }
            //3

            int m, a;

            Console.WriteLine("Digite o número de um mês: ");
            m = int.Parse(Console.ReadLine());

            switch (m)
            {
                case 1: Console.WriteLine("Janeiro- 31 dias");
                    break;

                case 2: Console.WriteLine("O ano é bissexto (1- sim, 2- não)? ");
                        a = int.Parse(Console.ReadLine());
                    switch (a)
                    {
                        case 1: Console.WriteLine("Fevereiro- 29 dias");
                            break;
                        case 2: Console.WriteLine("Fevereiro- 28 dias");
                            break;
                    }
                    break;
                case 3: Console.WriteLine("Março- 31 dias");
                    break;
                case 4: Console.WriteLine("Abril- 30 dias");
                    break;
                case 5: Console.WriteLine("Maio- 31 dias");
                    break;

                case 6: Console.WriteLine("Junho- 30 dias");
                    break;

                case 7: Console.WriteLine("Julho- 31 dias");
                    break;

                case 8: Console.WriteLine("Agosto- 31 dias");
                    break;

                case 9: Console.WriteLine("Setembro- 30 dias");
                    break; 

                case 10: Console.WriteLine("Outubro- 31 dias");
                    break;

                case 11: Console.WriteLine("Novembro- 30 dias");
                    break;

                case 12: Console.WriteLine("Dezembro- 31 dias");
                    break;

                default: Console.WriteLine("Opção inválida.");
                    break;
            }
            //4

            char c;
            int ni1, ni2;

            Console.WriteLine("Digite um número inteiro: ");
            ni1= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número inteiro: ");
            ni2= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua operação(+, -, *, /, ^");
            c= char.Parse(Console.ReadLine());

            switch (c)
            {
                case '+': Console.WriteLine("{0}", ni1 + ni2);
                    break;

                case '-': Console.WriteLine("{0}", ni1 - ni2);
                    break;

                case '*': Console.WriteLine("{0}", ni1 * ni2);
                    break;

                case '/': Console.WriteLine("{0}", ni1 / ni2);
                    break;

                case '^': Console.WriteLine("{0}", Math.Pow(ni1, ni2));
                    break;
           }
            //5

            float s, cargo;

            Console.WriteLine("Digite o seu salário: ");
            s= float.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu cargo(1- professor, 2- secretário, 3- publicitário, 4- Jornalista, 5- Mecânico, 6- Estagiário, 7- Técnico de TI:");
            cargo = float.Parse(Console.ReadLine());

            switch(cargo)
            {
                case 1: Console.WriteLine("Novo salário= {0}, ", s + ((7.5 / 100) * s), "salário antigo= {1}, ", s, "Diferença= {2}, ", s + ((7.5 / 100) * s) - s);
                    break;

                case 2: Console.WriteLine("Novo salário= {0}, ", s + ((9.7 / 100) * s), "salário antigo= {1}, ", s, "Diferença= {2}, ", s + ((9.7 / 100) * s) - s);
                    break;

                case 3: Console.WriteLine("Novo salário= {0}, ", s + ((11.7 / 100) * s), "salário antigo= {1}, ", s, "Diferença= {2}, ", s + ((11.7 / 100) * s) - s);
                    break;

                case 4: Console.WriteLine("Novo salário= {0}, ", s + ((8.9 / 100) * s), "salário antigo= {1}, ", s, "Diferença= {2}, ", s + ((8.9 / 100) * s) - s);
                    break;

                case 5: Console.WriteLine("Novo salário= {0}, ", s + ((13.24/ 100) * s), "salário antigo= {1}, ", s, "Diferença= {2}, ", s + ((13.24 / 100) * s) - s);
                    break;

                case 6: Console.WriteLine("Novo salário= {0}, ", s + ((10.4 / 100) * s), "salário antigo= {1}, ", s, "Diferença= {2}, ", s + ((10.4 / 100) * s) - s);
                    break;

                case 7: Console.WriteLine("Novo salário= {0}, ", s + ((14.6/ 100) * s), "salário antigo= {1}, ", s, "Diferença= {2}, ", s + ((14.6 / 100) * s) - s);
                    break;

                default: Console.WriteLine("Novo salário= {0}, ", s + ((43.5/100) * s), "salário antigo= {1}, ", s, "Diferença= {2}, ", s + ((43.5 / 100) * s) - s);
                    break;
                    
                   

            }
            //6

            float sm;

            Console.WriteLine("Digite seu salário mensal: ");
            sm = float.Parse(Console.ReadLine());

            if (sm <= 1903.98) {
                Console.WriteLine("Insento de impostos, salário líquido= {0}", sm);
                    }
            if (sm <= 2826.65 && sm >= 1903.99) ;
            {
                Console.WriteLine("Imposto= {0}, ", 7.5 / 100 * sm, "salário líquido= {1}", sm - (7.5 / 100 * sm));
                    }
            if(sm >= 2826.66 && sm<= 3751.05)
            {
                Console.WriteLine("Imposto= {0}, ", 15 / 100 * sm, "salário líquido= {1}", sm - (15 / 100 * sm));
            }

            if (sm >= 3751.06 && sm <= 4664.68)
            {
                Console.WriteLine("Imposto= {0}, ", 22.5 / 100 * sm, "salário líquido= {1}", sm - (22.5 / 100 * sm));
            }
            else { Console.WriteLine("Imposto= {0}, ", 27.5 / 100 * sm, "salário líquido= {1}", sm - (27.5 / 100 * sm));
            }


        }
    }
}
