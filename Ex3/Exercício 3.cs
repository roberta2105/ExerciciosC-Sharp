/******************************************************************************

Desenvolva um programa que receba como entrada um número inteiro que represente um dos 7 dias da semana
e imprima na tela se esse dia é útil, final de semana ou inválido.

Considere que Domingo é o dia 1 e Sábado o dia 7.

*******************************************************************************/

using System;
class Exercicio3 {
  static void Main() {
    
    Console.WriteLine("Digite um número");
    int dia = Convert.ToInt32(Console.ReadLine());
    
    switch (dia){
        
        case 1 : 
        Console.WriteLine("Final de semana");
        break;
        
        case 2 :
        Console.WriteLine("Dia útil");
        break;
        
        case 3 :
        Console.WriteLine("Dia útil");
        break;
        
        case 4 :
        Console.WriteLine("Dia útil");
        break;
        
        case 5 :
        Console.WriteLine("Dia útil");
        break;
        
        case 6 :
        Console.WriteLine("Dia útil");
        break;
        
        case 7 :
        Console.WriteLine("Final de semana");
        break;
        
        default :
        Console.WriteLine("Dia inválido!");
        break;
        
    }
    
    
  }
}