
namespace traffic_lights.Models
{
    public class GetRequestCircle
    {
        public int color { get; set; }
    }

    public enum Colors
    {
        red = 0,
        redandyellow = 1,
        yellow = 3,
        green = 2,
    }
    public class CircleModel
    {
        public int index { get; set; }
        public Colors color { get; set; }
        public double time { get; set; }
    }

}