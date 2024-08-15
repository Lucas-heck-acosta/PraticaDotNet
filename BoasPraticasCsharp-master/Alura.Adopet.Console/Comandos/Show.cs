using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "show", documentacao: "adopet show   <arquivo> comando que exibe no terminal o conteúdo do arquivo importado.")]

    internal class Show: IComando
    {
        public async Task ExecutarAsync(string[] args)
        {
            this.ExibirDadosImportados(caminhoDoArquivoASerExibido: args[1]);
        }
        private void ExibirDadosImportados(string caminhoDoArquivoASerExibido)
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
