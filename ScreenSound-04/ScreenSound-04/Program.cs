using System.Text.Json;
using ScreenSound_04.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        musicas[333].ExibirDetalhesDaMusica();
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
}