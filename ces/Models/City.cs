namespace ces.Models;

public class City : BaseModel
{
    public string Name { get; set; }
    public List<Route> Route { get; set; }
}
