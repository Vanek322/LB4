namespace LB4.Models;

public partial class TitlesGenre
{
    public int Id { get; set; }

    public short IdGenre { get; set; }

    public int IdAnime { get; set; }

    //навигационные св-ва
    public virtual AnimeTitle AnimeTitle { get; set; } = null!;

    public virtual Genre Genre { get; set; } = null!;
}
