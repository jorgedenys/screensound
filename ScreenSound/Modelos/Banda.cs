using ScreenSound.Modelos;

internal class Banda
{

    public string Nome { get; }

    private List<Album> albums = new List<Album>();

    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public void adicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void adicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}:");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }

}