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
        [Route("api/getdefault")]
        public Models.CircleModel getdefault()
        {
            return repository.GetDefault();
        }


        [HttpPost]
        [Route("api/GetCircle")]
        [Consumes("application/json")]
        public Models.CircleModel GetCircle(Models.GetRequestCircle request)
        {
            return repository.GetCircle(((Models.Colors)request.color));
        }
        

    }  
    
}