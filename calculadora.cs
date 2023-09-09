using System;

public class Calculadora
{
    public static void Main(string[] args)
    {
      Menu();
    }
    static void Menu(){
        
        Console.Clear();
        
        Console.WriteLine("Qual operacao voce deseja realizar?");
        Console.WriteLine("");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtracao");
        Console.WriteLine("3 - Divisao");
        Console.WriteLine("4 - Multiplicacao");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("");
        
        short opc = short.Parse(Console.ReadLine());
        
        switch(opc){
            case 1 :
            Soma();
            break;
            case 2 : 
            Subtracao();
            break;
            case 3 : 
            Divisao();
            break;
            case 4 : 
            Multiplicacao();
            break;
            case 5 : 
            System.Environment.Exit(0);
            break;
            default : Menu();
            break;
        }
    }
    static void Soma(){
        
        Console.WriteLine("-------Soma------");
        Console.WriteLine("Digite um numero:");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite outro numero:");
        int num2 = int.Parse(Console.ReadLine());
        
        int soma = num1 + num2;
        
        Console.WriteLine("A soma e: " + soma);
        Console.WriteLine("");
        Menu();
    }
    static void Subtracao(){
        
        Console.WriteLine("-----Sutracao----");
        Console.WriteLine("Digite um numero:");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite outro numero:");
        int num2 = int.Parse(Console.ReadLine());
        
        int subtracao = num1 - num2;
        
        Console.WriteLine("O resultado da subtracao e: " + subtracao);
        Console.WriteLine("");
        Menu();
    }
    static void Divisao(){
        
        Console.WriteLine("-----Divisao----");
        Console.WriteLine("Digite um numero:");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite outro numero:");
        int num2 = int.Parse(Console.ReadLine());
        
        int divisao = num1 / num2;
        
        Console.WriteLine("O resultado da divisao e: " + divisao);
        Console.WriteLine("");
        Menu();
    }
    static void Multiplicacao(){
        
        Console.WriteLine("------Multiplicacao-------");
        Console.WriteLine("Digite um numero:");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite outro numero:");
        int num2 = int.Parse(Console.ReadLine());
        
        int multiplicacao = num1 * num2;
        
        Console.WriteLine("O resultado da multiplicacao e: " + multiplicacao);
        Menu();
    }
}