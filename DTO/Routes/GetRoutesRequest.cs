namespace ces.DTO.Routes;

public class GetRoutesRequest
{
    public string StartCity { get; set; }
    public int Weight { get; set; }
    public DateTime Date { get; set; }
    public double[] Dimensions { get; set; }
    public string ParcelType { get; set; }
}
