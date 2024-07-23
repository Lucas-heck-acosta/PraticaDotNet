using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSound_04.Modelos
{
    internal class MusicasPreferidas
    {
        public string Nome { get; set; }
        public List<Musica> ListaDeMusicasFavoritas { get; }

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicasFavoritas = new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }

        public void ExebirMusicasFavoritas()
        {
            Console.WriteLine($"Musicas favoritas -> {Nome}");
            foreach (var musica in ListaDeMusicasFavoritas)
            {
                Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
            }
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = ListaDeMusicasFavoritas
            });
            string nomeDoArquivo = $"Musicas-favoritas-{Nome}.json";

            File.WriteAllText(nomeDoArquivo, json);
            Console.WriteLine($"JSON criado com sucesso {Path.GetFullPath(nomeDoArquivo)}" );
        }
    }
}
