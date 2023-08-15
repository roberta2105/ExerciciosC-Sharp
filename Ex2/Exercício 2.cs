/******************************************************************************

    Fácil 5- Faça um programa para a leitura de duas notas parciais de um aluno.  

    A mensagem “Aprovado”, se a média alcançada for maior ou igual a sete;
    A mensagem “Aprovado com Distinção”, se a média for igual a dez;
    A mensagem “Reprovado” se a média for menor de do que sete;

*******************************************************************************/

using System;
class Exercício2 {
  static void Main() {
    
    
    Console.WriteLine("Digite a nota 1 do aluno:");
    double nota1 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Digite a nota 2 do aluno:");
    double nota2 = Convert.ToDouble(Console.ReadLine());
    
    double media = (nota1 + nota2) / 2;
    
    if (media == 10.0){
        Console.WriteLine("Aprovado com Distinção");
    }
    
    else if (media >= 7.0){
        Console.WriteLine("Aprovado!");
    }
    
    else {
        Console.WriteLine("Reprovado");
    }
    
  }
}
