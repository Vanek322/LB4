using System;
using System.Collections.Generic;

namespace LB4.Models;

public partial class AnimeTitle
{
    public int Id { get; set; }

    public short IdType { get; set; }

    public string OriginalName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public short CountSeries { get; set; }

    public short Duration { get; set; }

    public string Stidio { get; set; } = null!;

    public string? Poster { get; set; }

    public string? Description { get; set; }



    // Навигационные св-ва
    public virtual Type Type { get; set; } = null!;

    public virtual ICollection<TitlesGenre> TitlesGenres { get; set; } = new List<TitlesGenre>();

    public virtual ICollection<TitlesStatus> TitlesStatuses { get; set; } = new List<TitlesStatus>();
}
