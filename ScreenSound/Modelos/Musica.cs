namespace ScreenSound.Modelos;

internal class Musica
{
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}.";

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

}
