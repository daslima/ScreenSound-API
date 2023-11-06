using System.Text.Json;

namespace ScreenSound.Model
{
    public class MusicasPreferidas
    {
        #region  Construtor
        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicaFavoritas = new List<Musica>();
        }
        #endregion

        #region  Propriedades
        public string? Nome { get;}
        public List<Musica>? ListaDeMusicaFavoritas { get; private set; }
        #endregion

        #region  Métodos
        public void adicionarMusicasFavoritas(Musica musica)
            => ListaDeMusicaFavoritas!.Add(musica);

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Musicas favoritas da {Nome}");

            foreach (var musica in ListaDeMusicaFavoritas!)
                Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }

        public void GerarArquivoJson()
        {
            try
            {
                string json = JsonSerializer.Serialize(new 
                {
                    nome = Nome,
                    musicas = ListaDeMusicaFavoritas
                });

                string nomeDoArquivo = $"musicas-favoritas={Nome}.json";

                File.WriteAllText(nomeDoArquivo, json);
                Console.WriteLine("O arquivo Json foi criado com sucesso.");
                Console.WriteLine($"{Path.GetFullPath(nomeDoArquivo)}");
            }
            catch (Exception)
            {
                throw;
            }
        }    
        #endregion
    }
}