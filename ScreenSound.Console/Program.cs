

using System.Text.Json;
using ScreenSound.Model;

using (var client = new HttpClient())
{
    try
    {
        string baseURL = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";
        string resp =  await client.GetStringAsync(baseURL);
        Console.WriteLine(resp);

        // o ! = fala para o compilador que não vira nulo
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resp)!;
        musicas[1].ExibirDetalheDaMusica();
    }
    catch (Exception error)
    {
        Console.WriteLine($"Have a problem {error.Message.ToLower()}");
    }

}