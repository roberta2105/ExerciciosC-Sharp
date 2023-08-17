using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string acao = "";
            string caminho = "usuario.txt";
            string nome = "", email = "", telefone = "", rg = "";
            
            Console.WriteLine("*--------------------------*");
            Console.WriteLine("     Seja bem-vindo!");
            Console.WriteLine("*--------------------------*");
            Console.WriteLine(" C - Cadastro no sistema");
            Console.WriteLine(" V - Visualizar dados");
            Console.WriteLine(" S - Sair");
            Console.WriteLine("*--------------------------*");
            Console.Write(" Digite a opção desejada (C/ V/ S) :");

            acao = Console.ReadLine().ToUpper();
            Console.WriteLine();

            while (acao != "S")
            {

                if (acao == "C")
                {
                    Console.Write(" Informe seu nome: ");
                    nome = Console.ReadLine();

                    Console.Write(" Informe seu e-mail: ");
                    email = Console.ReadLine();

                    Console.Write(" Informe seu Telefone: ");
                    telefone = Console.ReadLine();

                    Console.Write(" Informe seu RG: ");
                    rg = Console.ReadLine();
                    Console.WriteLine("\n*------------------------------*");
                        Console.Write(" Cadastro concluído com sucesso!");
                    Console.WriteLine("\n*------------------------------*");

                    StreamWriter sw = new StreamWriter(caminho, true);

                    sw.WriteLine(" Nome: " + nome);
                    sw.WriteLine(" E-mail: " + email);
                    sw.WriteLine(" Telefone: " + telefone);
                    sw.WriteLine(" RG: " + rg);
                    

                    sw.Close();
                }
                else if (acao == "V")
                {
                    StreamReader sr = new StreamReader(caminho);

                    while (sr.EndOfStream != true)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }

                    sr.Close();
                }

                Console.WriteLine();
                Console.WriteLine(" Pressione uma tecla para continuar...");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine(" C - Cadastro no sistema");
                Console.WriteLine(" V - Visualizar dados");
                Console.WriteLine(" S - Sair");
                Console.WriteLine("--------------------------");
                Console.Write(" Digite a opção desejada (C/ V/ S) :");

                acao = Console.ReadLine().ToUpper();
                Console.WriteLine();

            }
        }
    }
}