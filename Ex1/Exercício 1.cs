//Fácil 2- Faça um programa que peça um valor e mostre na tela se o valor é positivo ou negativo

using System;
class Exercicio2 {
  static void Main() {
      
      Console.WriteLine("Digite um número");
      int num = Convert.ToInt32(Console.ReadLine());
      
      if (num >= 0){
          Console.WriteLine("Esse número é positivo!");
      }
      else {
          Console.WriteLine("Esse número é negativo!");
      }
      
   
  }
}