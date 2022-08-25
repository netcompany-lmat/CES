namespace ces.Models;

public class ParcelType : BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double ExtraFee { get; set; }
}
