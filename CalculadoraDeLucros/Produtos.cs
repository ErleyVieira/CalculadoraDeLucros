using System;

namespace CalculadoraDeLucros
{
    internal class Produtos
    {
        double marujinho = 0.42;
        double picoleKids = 0.70;
        double sorveteNoPalito = 0.75;
        double supremeCremosinho = 1.10;
        double supremeMarujinho = 1.20;
        double moreninha = 1.20;
        double sundae = 1.66;



        public double Pedido()
        {

            Console.WriteLine("Qual o valor da venda ?");
            double valorVenda = double.Parse(Console.ReadLine());
            double valorDescontado = 0;
            Console.WriteLine("[1]Ifood");
            Console.WriteLine("[2]Ifood com pagamento na entrega");
            Console.WriteLine("[3]Uber entrega própria");
            Console.WriteLine("[4]Uber entrega parceira");
            Console.WriteLine("[5]Rappi");
            Console.WriteLine("Qual a plataforma dessa venda ?");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)

                valorDescontado = valorVenda - valorVenda * 0.155;

            else if (opcao == 2)

                valorDescontado = valorVenda - valorVenda * 0.12;

            else if (opcao == 3)

                valorDescontado = valorVenda - valorVenda * 0.17;

            else if (opcao == 4)

                valorDescontado = valorVenda - valorVenda * 0.3;

            else if (opcao == 5)

                valorDescontado = valorVenda - valorVenda * 0.1;

            Console.WriteLine("Quais foram os produtos ?");
            Console.WriteLine("1. Marujinho");
            Console.WriteLine("2. Picolé Kid's");
            Console.WriteLine("3. Sorvete no palito");
            Console.WriteLine("4. Supreme cremosinho");
            Console.WriteLine("5. Supreme marujinho");
            Console.WriteLine("6. Moreninha");
            Console.WriteLine("7. Sundae");

            int n = int.Parse(Console.ReadLine());


            while (n != 0)
            {
                if (n == 1)
                {
                    Console.WriteLine("Quantos marujinhos ?");

                    int numeroDeMarujinhos = int.Parse((Console.ReadLine()));
                    valorDescontado -= marujinho * numeroDeMarujinhos;
                }
                else if (n == 2)
                {
                    Console.WriteLine("Quantos picolés Kid's ?");
                    int numeroDeMarujinhos = int.Parse((Console.ReadLine()));

                    valorDescontado -= picoleKids * numeroDeMarujinhos;
                }
                else if (n == 3)
                {
                    Console.WriteLine("Quantos sorvetes no palito ?");
                    int numeroDeMarujinhos = int.Parse((Console.ReadLine()));

                    valorDescontado -= sorveteNoPalito * numeroDeMarujinhos;
                }
                else if (n == 4)
                {
                    Console.WriteLine("Quantos supreme cremosinho ?");
                    int numeroDeMarujinhos = int.Parse((Console.ReadLine()));

                    valorDescontado -= supremeCremosinho * numeroDeMarujinhos;
                }
                else if (n == 5)
                {
                    Console.WriteLine("Quantos supreme marujinho ?");
                    int numeroDeMarujinhos = int.Parse((Console.ReadLine()));

                    valorDescontado -= supremeMarujinho * numeroDeMarujinhos;
                }
                else if (n == 6)
                {
                    Console.WriteLine("Quantas moreninhas ?");
                    int numeroDeMarujinhos = int.Parse((Console.ReadLine()));

                    valorDescontado -= moreninha * numeroDeMarujinhos;
                }
                else if (n == 7)
                {
                    Console.WriteLine("Quantos sundaes ?");
                    int numeroDeMarujinhos = int.Parse((Console.ReadLine()));

                    valorDescontado -= sundae * numeroDeMarujinhos;
                }

                Console.WriteLine("Mais algum produto ?");
                Console.WriteLine("Quais foram os produtos ?");
                Console.WriteLine("1. Marujinho");
                Console.WriteLine("2. Picolé Kid's");
                Console.WriteLine("3. Sorvete no palito");
                Console.WriteLine("4. Supreme cremosinho");
                Console.WriteLine("5. Supreme marujinho");
                Console.WriteLine("6. Moreninha");
                Console.WriteLine("7. Sundae");
                n = int.Parse(Console.ReadLine());

            }
            valorDescontado.ToString("F2");

            return valorDescontado;


        }

    }
}
