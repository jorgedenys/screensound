namespace ScreenSound.Modelos;

internal class Album
{
    public string Nome { get; }

    private List<Musica> musicas = new List<Musica>();

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public Album(string nome)
    {
        Nome = nome;
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:");
        foreach (Musica musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Duração do álbum: {DuracaoTotal} segundos");
    }

}
