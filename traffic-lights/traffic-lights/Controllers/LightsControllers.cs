using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace traffic_lights.Controllers
{
  
    [ApiController]     
    public class LightsController : ControllerBase
    {
      
        private readonly ILogger<LightsController> _logger;

        static readonly Models.ICircleRepository repository  =new Models.CircleRepository();

        public LightsController(ILogger<LightsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("lights/get_default")]
        public Models.CircleModel GetDefault()
        {
            return repository.GetDefault();
        }


        [HttpPost]
        [Route("lights/get_circle")]
        [Consumes("application/json")]
        public Models.CircleModel GetCircle(Models.GetRequestCircle request)
        {
            return repository.GetCircle(((Models.Colors)request.color));
        }
        

    }  
    
}