// 18) Escreva um programa que leia um número inteiro (variável CODIGO). Verificar se o código é igual a 1, igual a 2 ou igual a 3. Caso não seja, apresentar a mensagem “Código inválido”. Ao ser verificado o código e constatado que é um valor válido, o programa deve verificar cada código em separado para determinar seu valor por extenso, ou
 // seja, apresentar a mensagem “um”, ”dois” ou “três”. (Utilizar 
 // comando Switch). 

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Digite o codigo: ");
        int codigo = Convert.ToInt32(Console.ReadLine());
        
        switch (codigo){
        
            case 1: 
            Console.WriteLine("Um");
            break;
            
            case 2:
            Console.WriteLine("Dois");
            break;
            
            case 3:
            Console.WriteLine("Tres");
            break;
            
            default:
            Console.WriteLine("Codigo invalido!");
            break;
        }
        
    }
}
