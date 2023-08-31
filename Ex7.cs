// 3) Faça um programa para pagamento de comissão de vendedores de peças levando-se em consideração que sua comissão será de 5% do total da venda e que você tem os seguintes dados:

// - Identificação do vendedor
// - Código da peça
// - Preço unitário da peça
// - Quantidade vendida

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // string vendedor;
        // int codigo;
        // double valorUnitario;
        // int quantidadeVend;
           double comissao;
        
        Console.WriteLine("Digite o nome do vendedor: ");
        string vendedor = Console.ReadLine();
        
        Console.WriteLine("Digite o codigo da peca: ");
        int codigo = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Digite o valor unitario da peca: ");
        double valorUnitario = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Digite a quantidade de pecas vendidas: ");
        int quantidadeVend = Convert.ToInt32(Console.ReadLine());
        
        comissao = (valorUnitario * quantidadeVend) * 0.05 ;
        
        Console.WriteLine("A comissao do vendedor sera: " + comissao);
        
        
    }
}