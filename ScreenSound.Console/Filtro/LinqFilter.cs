using System.ComponentModel.Design;
using ScreenSound.Model;

namespace ScreenSound.Console.Filtro
{
    public class LinqFilter
    {
        #region  Métodos
        public static void FiltrarTodosOsGenerosMusicais(IList<Musica> musicas)
        {
            var todosOsGeneros = musicas.Select(m => m.Genero).Distinct().ToList();

            foreach (var genero in todosOsGeneros)
                System.Console.WriteLine($"- {genero}");
        }

        public static void OrdenarArtistasPorNome(IList<Musica> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(m => m.Artista)
                .Select(a => a.Artista).Distinct();

            foreach (var artista in artistasOrdenados)
                System.Console.WriteLine($"- {artista}");

            System.Console.WriteLine($"Total de artistas: {artistasOrdenados.Count()}");
        }
        
        public static void FIltrarArtistasPorGeneroMusical(IList<Musica> musicas, string genero)
        {
            var artistaPorGenero = musicas.Where(m => 
                m.Genero!.Contains(genero)).OrderBy(a => a.Artista)
                .Select(a => a.Artista).Distinct();

            foreach (var artista in artistaPorGenero)
                System.Console.WriteLine($"{artista}");
        }

        public static void FiltrarMusicaPorArtista(IList<Musica> musicas, string artista)
        {
            var musicasDoArtista = musicas.Where(m => 
                m.Artista!.Equals(artista)).OrderBy(m => m.Nome)
                .Select(m => m.Nome).Distinct();

            System.Console.WriteLine($"Musicas do artista: {artista}");
            foreach (var musica in musicasDoArtista)
                System.Console.WriteLine($"- {musica}");

        }

        public static void FiltrarMusicasPorAno(IList<Musica> musicas, int ano)
        {
            var musicasPorAno = musicas.Where(m => 
                m.Ano == ano).OrderBy(m => m.Nome)
                .Select(m => m.Nome).Distinct();

            System.Console.WriteLine($"Musicas do ano {ano}");
            foreach (var musica in musicasPorAno)
                System.Console.WriteLine($"- {musica}");
        }

        public static void OrdenarArtistasPorGenero(IList<Musica> musicas)
        {
            var artistasPorgenero = from artista in musicas
                                    group artista by artista.Genero;

            foreach (var artistas in artistasPorgenero)
            {
                foreach (var artista in artistas)
                    System.Console.WriteLine($"- Artista: {artista.Artista} \nGenêro: {artista.Genero}");
            }
                
        }
        #endregion
    }
}