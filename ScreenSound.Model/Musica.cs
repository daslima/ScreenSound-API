using System.Text.Json.Serialization;

namespace ScreenSound.Model
{
    public class Musica
    {
        #region  Propriedades
        [JsonPropertyName("song")]
        public string? Nome { get; set; }

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        [JsonPropertyName("year")]
        [JsonConverter(typeof(IntConverter))]
        public int Ano { get; set; }

        #endregion

        #region  Métodos
        public void ExibirDetalheDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Musica: {Nome}");
            Console.WriteLine($"Duração: {Duracao / 1000}");
            Console.WriteLine($"Genêro: {Genero}");
            Console.WriteLine($"Ano: {Ano}");
        }
        #endregion

    }
}