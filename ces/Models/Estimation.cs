namespace ces.Models
{
    public class Estimation : BaseModel
    {
        public double Time { get; set; }
        public double Cost { get; set; }
        public EstimationType Type { get; set; }
    }
}
