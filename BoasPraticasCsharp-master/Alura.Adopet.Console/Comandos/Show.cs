using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "show", documentacao: "adopet show   <arquivo> comando que exibe no terminal o conteúdo do arquivo importado.")]

    internal class Show
    {
        public void ExibirDadosImportados(string caminhoDoArquivoASerExibido)
        {
            LeitorDeArquivo leitor = new LeitorDeArquivo();
            List<Pet> listaDePets = leitor.RealizaLeitura(caminhoDoArquivoASerExibido);

            foreach (Pet pet in listaDePets)
            {
                System.Console.WriteLine(pet);
            }
        }
    }
}
