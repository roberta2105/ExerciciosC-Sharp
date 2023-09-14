internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu(){
        Console.WriteLine("---Olá! Bem-vindo ao TextEditor---");
        Console.WriteLine("O que você gostaria de fazer?");
        Console.WriteLine("1 - Abrir arquivo");
        Console.WriteLine("2 - Criar novo arquivo");
        Console.WriteLine("0 - Sair");

        short opc = short.Parse(Console.ReadLine());

        switch(opc){
            case 1 : 
            Abrir();
            break;
            case 2 : 
            Editar();
            break;
            case 0 :
            System.Environment.Exit(0);
            break;
            default: 
            Menu();
            break;
        }

        static void Abrir(){
            Console.Clear();
            Console.WriteLine("Qual o caminho para ler o arquivo?");
            string path = Console.ReadLine();

            using(var arquivo = new StreamReader(path)){
                string texto = arquivo.ReadToEnd();
                Console.WriteLine(texto);
            }
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar(){
            Console.Clear();
            Console.WriteLine("Digite o seu texto abaixo: (Para sair precione a tecla ESC)");
            Console.WriteLine("-----------------------------------------------------------");

            string texto = "";

            do{
                //Mantém o conteúdo existente e adiciona um novo.
                texto += Console.ReadLine();
                //Adiciona uma quebra de linha em relação ao texto velho para o novo.
                texto += Environment.NewLine;
            }

            //Enquanto a tecla digitada for esc.
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(texto);
        }

        static void Salvar(string texto){
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();


            // using (var arquivo = new StreamWriter(path)): Esta linha cria uma instância da 
            // classe StreamWriter para escrever no arquivo no caminho especificado pelo usuário. 
            // O uso do using garante que o recurso (o arquivo neste caso) seja liberado automaticamente 
            // quando o bloco using for concluído, o que é uma boa prática para evitar vazamentos de recursos.

            using(var arquivo = new StreamWriter(path)){
                arquivo.Write(texto); 
            }
            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();
            
        }
    }
    
}