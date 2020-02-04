using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meteorite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestJsonAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeteoriteController : ControllerBase
    {
       
        private readonly ILogger<MeteoriteController> _logger;

        public MeteoriteController(ILogger<MeteoriteController> logger)
        {
            _logger = logger;
        }

        // GET api/values/LargePayload
        [HttpGet]
        [Route("LargePayload")]
        public async Task<List<MeteoriteLanding>> GetLargePayloadAsync()
        {
            var result = await Meteorite.MeteoriteDetail.GetMeteoriteLendingDetailsLargePayLoad("dummy");
            return result;          
        }

        [HttpGet]
        [Route("SmallPayload")]
        public async Task<List<MeteoriteLanding>> GetSmallPayloadAsync()
        {
            var result = await Meteorite.MeteoriteDetail.GetMeteoriteLendingDetailsSmallPaylad();
            return result;
        }
    }
}
