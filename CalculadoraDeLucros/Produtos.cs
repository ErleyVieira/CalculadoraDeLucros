using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeLucros
{
    internal class Produtos
    {
        

        public double Pedido()
        {
            Console.WriteLine("Qual o valor da venda ?");
            double valorVenda = double.Parse(Console.ReadLine());
            double valorDescontado = 0;
            Console.WriteLine("[1]Ifood" +
                                "[2]Ifood com pagamento na entrega" +
                                "[3]Uber entrega própria" +
                                "[4]Uber entrega parceira" +
                                "[5]Rappi" +
                                "Qual a plataforma dessa venda ?))");
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

            return double.Parse(Console.WriteLine($"O valor da venda com descontos foi de {valorDescontado}"));
        }
    }
}
