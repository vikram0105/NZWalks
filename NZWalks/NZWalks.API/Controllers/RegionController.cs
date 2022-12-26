using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("controller")]
    public class RegionController : Controller
    {
        [HttpGet]
        public IActionResult GetAllRegion()
        {
            var regions = new List<Region>()
            {
                new Region()
                {
                    Id = Guid.NewGuid(),
                    Name = "Wellinton",
                    Code = "WLG",
                    Area = 227755,
                    Lat = 1.8822,
                    Long = 299.88,
                    Poulation = 500000
                },

                new Region()
                {
                    Id = Guid.NewGuid(),
                    Name = "Auckland",
                    Code = "AUCK",
                    Area = 227755,
                    Lat = 1.8822,
                    Long = 299.88,
                    Poulation = 500000
                }
            };

           return Ok(regions);
        }
    }
}
