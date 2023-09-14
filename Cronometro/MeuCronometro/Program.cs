using System.Threading;
using System.Diagnostics;

internal class Program
{

    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu(){
        Console.WriteLine("----------------Cronômetro---------------");
        Console.WriteLine("- Quantos segundos deseja contar? ex: 10s");
        Console.WriteLine("- Quantos minutos deseja contar? ex: 2m");
        Console.WriteLine("0 - Sair");

        string data = Console.ReadLine().ToLower();
        
        // O data.Length() vai contar quantos caracteres tem na string data, o data.Length -1, vai subtrair 1 número da string, resultando no 
        // último número.
        // O data.Length -1, "1" > retorna apenas um caracter.
        char tipo = char.Parse(data.Substring(data.Length -1, 1));

        //O 0 no início, vai fazer com que a contagem de caracteres comece no 0. O -1 faz com que conte todos os caracteres da string, 
        // subtraindo o último. Ex: 10s > 10.
        int tempo = int.Parse(data.Substring(0, data.Length -1));

        int multi = 1;

        if(tipo == 'm'){
            multi = 60;
        }
        if(tipo == '0'){
            System.Environment.Exit(0);
        }
        Contagem(tempo * multi);
    }

    static void Contagem(int tempo){
        int tempoAtual = 0;

        while( tempoAtual != tempo){
            tempoAtual++;

        Console.WriteLine(tempoAtual);
        Thread.Sleep(1000);
        }
        Menu();
    }
        
    
}