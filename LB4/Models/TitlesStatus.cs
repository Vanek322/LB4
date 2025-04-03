using System;
using System.Collections.Generic;

namespace LB4.Models;

public partial class TitlesStatus
{
    public int Id { get; set; }

    public short IdStatus { get; set; }

    public int IdAnime { get; set; }

    public DateOnly? DateStatus { get; set; }

    public virtual AnimeTitle IdAnimeNavigation { get; set; } = null!;

    public virtual Status IdStatusNavigation { get; set; } = null!;
}
