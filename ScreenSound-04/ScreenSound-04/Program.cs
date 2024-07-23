using System.Text.Json;
using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Evanescence");
        var musicasPreferidas = new MusicasPreferidas("Lucas");
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[44]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[122]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[1002]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[88]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[34]);

        musicasPreferidas.ExebirMusicasFavoritas();
        musicasPreferidas.GerarArquivoJson();



    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }

    /*
    try
    {
        string respostacarros = await client.getstringasync("https://raw.githubusercontent.com/arthurocfernandes/exerc-cios-c-/curso-4-aula-2/jsons/carros.json");

        var carros = jsonserializer.deserialize<list<carro>>(respostacarros);
        foreach(carro carro in carros)
        {
            carro.exibirdetalhesdocarro();
        }

    }
    catch (exception e)
    {
        console.writeline(e);
    }
    */
}