namespace traffic_lights.Models
{
    public interface ICircleRepository
    {
    CircleModel GetDefault();
    CircleModel GetCircle(Colors _color);
    }
}