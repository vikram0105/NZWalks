using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Repository;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("controller")]
    public class RegionController : Controller
    {
        private readonly IRegionsRepository _regionsRepository;
        private readonly IMapper _mapper;
        
        public RegionController(IRegionsRepository regionsRepository, IMapper mapper)
        {
            this._regionsRepository = regionsRepository;            
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRegion()
        {
            var regions = await _regionsRepository.GetAllAsync();

            //return dto

            //var regionsDto = new List<Models.Dtos.RegionDto>();

            //regions.ToList().ForEach(region => {
            //    var regionDto = new Models.Dtos.RegionDto()
            //    {
            //        Id = region.Id,
            //        Code = region.Code,
            //        Name = region.Name,
            //        Area = region.Area,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Poulation = region.Poulation
            //    };

            //    regionsDto.Add(regionDto);
            //});

            var regionsDto = _mapper.Map<List<Models.Dtos.RegionDto>>(regions);

           return Ok(regionsDto);
        }
    }
}
