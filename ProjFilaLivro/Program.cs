using System;

namespace ProjFilaLivro
{
    internal class Program
    {

        static Livro InserirLivro()
        {
            Console.WriteLine("Cadastro de Livro");
            int ISBN;
            string Titulo;
            int AnoPublicacao;

            Console.WriteLine("Digite o ISBN:");
            ISBN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Titulo:");
            Titulo = Console.ReadLine();
            Console.WriteLine("Digite o Ano de Publicação:");
            AnoPublicacao = Convert.ToInt32(Console.ReadLine());

            return new Livro(ISBN, Titulo, AnoPublicacao);
        }

        static void Main(string[] args)
        {
            
            Fila_Livro livro = new Fila_Livro();

            int opc = 0;

            while (opc != 6)
            {
                Console.WriteLine("Digite uma opção: ");
                Console.WriteLine("1 - Cadastrar Livro ");
                Console.WriteLine("2 - Remover Livro ");
                Console.WriteLine("3 - Imprimir Livro ");
                Console.WriteLine("4 - Recuperar quantidade de Livro ");
                Console.WriteLine("5 - Buscar Livro ");
                Console.WriteLine("6 - Sair");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        livro.push(InserirLivro());
                        Console.WriteLine("Livro inserido");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        livro.pop();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        livro.print();
                        break;
                    case 4:
                        Console.Clear();
                        livro.Qtd();
                        break;
                    case 5:
                        Console.Clear();  
                        livro.buscar();
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
