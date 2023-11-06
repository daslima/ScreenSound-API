

using System.Text.Json;
using ScreenSound.Console.Filtro;
using ScreenSound.Model;

using (var client = new HttpClient())
{
    try
    {
        string baseURL = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";
        string resp =  await client.GetStringAsync(baseURL);
        //Console.WriteLine(resp);

        // o ! = fala para o compilador que não vira nulo
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resp)!;
        
        //Desafios
        //1 - Exibir todos os gêneros musicais da lista;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        
        //2 - Ordenar os artistas por nome;
        //LinqFilter.OrdenarArtistasPorNome(musicas);
        
        //3 - Filtrar artistas por gênero musical;
        //LinqFilter.FIltrarArtistasPorGeneroMusical(musicas, "hip hop");
        
        //4 - Filtrar as músicas de um artista.
        //LinqFilter.FiltrarMusicaPorArtista(musicas,"2Pac");
        
        LinqFilter.FiltrarMusicasPorAno(musicas, 2012);

    }
    catch (Exception error)
    {
        Console.WriteLine($"Have a problem {error.Message.ToLower()}");
    }

}