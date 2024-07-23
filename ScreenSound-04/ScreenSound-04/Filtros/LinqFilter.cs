using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

            foreach(var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();

            foreach(var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($"- {artista}");
            }    
        }

        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
        {
            var musicasDoArtista = musicas.Where(musica => musica.Artista.Equals(artista)).ToList();

            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
        }

        public static void FiltrarDoSustenido(List<Musica> musicas)
        {
            var musicasDoSustenido = musicas.Where(musica => musica.Key == 1).ToList();

            foreach (var musica in musicasDoSustenido)
            {
                musica.ExibirDetalhesDaMusica();
            }
        }
    }
}
