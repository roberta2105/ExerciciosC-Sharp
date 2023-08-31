// Faça um programa que:

// - Leia a cotação do dólar
// - Leia um valor em dólares
// - Converta esse valor para Real
// - Mostre o resultado 

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
       double real;
       
        Console.WriteLine("Qual a cotacao do dolar atualmente?");
        double cot = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Digite um valor em dolar:");
        double valor = Convert.ToDouble(Console.ReadLine());
        
        real = (cot * valor);
        
        Console.WriteLine("Esse valor em reais é: " + real);
        
    }
}