using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace traffic_lights.Models
{
    public class CircleRepository : ICircleRepository
    {
        private List<CircleModel> circles = new List<CircleModel>();
        public CircleRepository()
        {

            circles.Add(new CircleModel() { index = 1, color = Colors.red, time = 3 });
            circles.Add(new CircleModel() { index = 2, color = Colors.redandyellow, time = 1.5 });
            circles.Add(new CircleModel() { index = 3, color = Colors.green, time = 3 });
            circles.Add(new CircleModel() { index = 4, color = Colors.yellow, time = 1.5 });
        }

        public CircleModel GetDefault()
        {
            return circles.Where(x => x.color == Colors.red).FirstOrDefault();
        }

        public CircleModel GetCircle(Colors _color)
        {
            int indexPrev = circles.Where(x => x.color == _color).FirstOrDefault().index;
            int newIndex = (indexPrev == 4) ? 1 : indexPrev + 1;
            return circles.Where(x => x.index == newIndex).FirstOrDefault();

        }
    }
}