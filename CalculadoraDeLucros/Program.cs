using System;

namespace CalculadoraDeLucros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Produtos p = new ();

            double venda = p.Pedido();

            Console.WriteLine(venda);

        }
    }
}
