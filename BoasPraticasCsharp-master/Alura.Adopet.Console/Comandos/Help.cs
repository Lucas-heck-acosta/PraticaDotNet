﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "help", documentacao: "adopet help comando que exibe informações da ajuda. \n" +
        "adopet help <NOME_COMANDO> para acessar a ajuda de um comando específico.")]
    internal class Help: IComando
    {

        public async Task ExecutarAsync(string[] args)
        {
            this.MostrarListaDeAjuda(args);
        }


        private Dictionary<string, DocComando> docs;
        public Help()
        {
            docs = DocumentacaoDoSistema.toDictionary(Assembly.GetExecutingAssembly());
        }
        private void MostrarListaDeAjuda(string[] argumentos)
        {
            int quantidadeDeArgumentos = argumentos.Length;
            System.Console.WriteLine("Lista de comandos.");
            // se não passou mais nenhum argumento mostra help de todos os comandos
            if (quantidadeDeArgumentos == 1)
            {
                System.Console.WriteLine("adopet help <parametro> ous simplemente adopet help  " +
                     "comando que exibe informações de ajuda dos comandos.");
                System.Console.WriteLine("Adopet (1.0) - Aplicativo de linha de comando (CLI).");
                System.Console.WriteLine("Realiza a importação em lote de um arquivos de pets.");
                System.Console.WriteLine("Comando possíveis: ");

                foreach (var doc in docs.Values)
                {
                    System.Console.WriteLine(doc.Documentacao);
                }

            }
            // exibe o help daquele comando específico
            else if (quantidadeDeArgumentos == 2)
            {
                string comandoASerExibido = argumentos[1];
                if (docs.ContainsKey(comandoASerExibido))
                {
                    var comando = docs[comandoASerExibido];
                    System.Console.WriteLine(comando.Documentacao);
                }

            }
        }
    }
}
