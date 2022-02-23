using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFilaLivro
{
    internal class Livro
    {

        public int ISBN { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public Livro Proximo { get; set; }

        public Livro(int iSBN, string titulo, int anoPublicacao)
        {
            ISBN = iSBN;
            Titulo = titulo;
            AnoPublicacao = anoPublicacao;
            Proximo = null;
        }

        public override string ToString()
        {
            return "=============== DADOS DO LIVRO =============      \n"
                    + "ISBN: "          + ISBN +                     "\n" 
                    + "Titulo: "        + Titulo +                   "\n"
                    + "Publicação: "    + AnoPublicacao +            "\n";
        }


    }
}
