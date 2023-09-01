// 1) Faça um programa para calcular o estoque médio de uma peça, sendo que:
// ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2. 

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int estMed;
       int quantMax;
       int quantMin;
       
       Console.WriteLine("Qual a quantidade maxíma?");
       quantMax = Convert.ToInt32(Console.ReadLine());
       
       Console.WriteLine("Qual a quantidade mínima?");
       quantMin = Convert.ToInt32(Console.ReadLine());
       
       estMed = (quantMax + quantMin) / 2;
       
       Console.WriteLine("O estoque médio dessa peça é: " + estMed);
       
       
    }
}