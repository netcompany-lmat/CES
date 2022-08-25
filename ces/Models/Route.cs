namespace ces.Models;

public class Route : BaseModel
{
    public Guid A { get; set; }
    public Guid B { get; set; }
    public int Distance { get; set; }
}
