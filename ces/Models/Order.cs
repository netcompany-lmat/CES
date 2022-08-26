namespace ces.Models;

public class Order : BaseModel
{
    public City? StartCity { get; set; }
    public City? DesCity { get; set; }
    public double Price { get; set; }
    public DateTime DateTime { get; set; }
    public string? RoundType { get; set; }

}
