namespace ces.Models;

public class Route : BaseModel
{
    public int Distance { get; set; }
    public List<City> Cities { get; set; }
}
