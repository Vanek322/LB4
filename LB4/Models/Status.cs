namespace LB4.Models;

public partial class Status
{
    public short Id { get; set; }

    public string StatusName { get; set; } = null!;

    //навигационные св-ва
    public virtual ICollection<TitlesStatus> TitlesStatuses { get; set; } = new List<TitlesStatus>();
}
