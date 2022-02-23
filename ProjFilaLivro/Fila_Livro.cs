using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFilaLivro
{
    internal class Fila_Livro
    {

        public Livro Head { get; set; }
        public Livro Tail { get; set; }
        public int qtd;

        public Fila_Livro()
        {
            Tail = null;
            Head = null;
            //Console.WriteLine("Pilha de Livros criada com sucesso: ");
        }

        public void push(Livro aux)
        {
            if (vazia())
            {
                Head = Tail = aux;
            }
            else
            {
                Tail.Proximo = aux;     //Encadeamento da nova pessoa
                Tail = aux;             // Atualizo controle da cauda (Tail)
            }
            qtd++;
        }

        public void print()
        {
            if (vazia())
            {
                Console.WriteLine(" -- FILA VAZIA -- ");
            }
            else
            {
                Console.WriteLine(" -- OS ELEMENTOS DA PILHA SÃO:  -- ");
                Livro aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                    Console.WriteLine("Digite algo para  parar");
                    Console.ReadKey();
                } while (aux != null);
                Console.WriteLine(" -- FIM DA IMPRESSÃO -- ");
            }
        }

        public bool vazia() // verificar se o top está vazio
        {
            if ((Head == null) && (Tail == null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void pop()
        {
            if (vazia())
            {
                Console.WriteLine(" -= FILA VAZIA -- ");
            }
            else
            {
                Head = Head.Proximo;
                if (Head == null)
                {
                    Tail = null;    //Volto o controle da Tail da Fila
                }
                qtd--;
            }
        }

        public void Qtd()
        {
            if (vazia())
            {
                Console.WriteLine(" -- FILA VAZIA -- ");
            }
            else
            {
                Console.WriteLine("\nA quantidade: {0}", qtd);
            }

        }

        public void buscar()
        {
            if (vazia())
            {
                Console.WriteLine(" -- FILA VAZIA -- ");
            }
            else
            {
                Console.WriteLine("Digite uma opção ");
                Console.WriteLine("1 - Buscar por ISBN ");
                Console.WriteLine("2 -  Buscar por Titulo ");
                int opc = Convert.ToInt32(Console.ReadLine());              
                Livro aux = Head;
                Console.Clear();
                
                
                if(opc == 1)
                {
                    Console.WriteLine("Você escolheu Buscar por ISBN");
                    Console.WriteLine("Digite o número do ISBN");
                    int NumISBN = Convert.ToInt32(Console.ReadLine());
                    do
                    {
                        if (NumISBN == aux.ISBN)
                        {
                            Console.WriteLine(aux.ToString());
                        }
                        aux = aux.Proximo;
                    } while (aux != null);
                    
                }  

                if(opc == 2)
                {
                    Console.WriteLine("Você escolheu Buscar por Titulo");
                    Console.WriteLine("Digite o nome do Titulo: ");
                    string NomeTitu = Console.ReadLine();
                    do
                    {
                        if(NomeTitu == aux.Titulo)
                        {
                            Console.WriteLine(aux.ToString());
                        }
                        aux = aux.Proximo;
                    }while (aux != null);
                }
                

                                             
            }
           
        }

    }
}
