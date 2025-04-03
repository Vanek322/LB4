using System;
using System.Collections.Generic;

namespace LB4.Models;

public partial class Genre
{
    public short Id { get; set; }

    public string GenreName { get; set; } = null!;

    //навигационные св-ва
    public virtual ICollection<TitlesGenre> TitlesGenres { get; set; } = new List<TitlesGenre>();
}
