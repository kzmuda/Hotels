using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Hotels.DataManipulation;
using Hotels.Model;
using Hotels.Model.Country;
using AAA.Common;
using Newtonsoft.Json;

namespace Hotels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CountryController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetCountries([FromQuery] RequestParameters requestParameters)
        {
            //var countries = _uow.GetAllCountriesWithHotels();
            var countries = _uow.Countries.GetAllParams(requestParameters);

            var result = _mapper.Map<List<CountryDto>>(countries);

            var metadata = new
            {
                countries.CurrentPage,
                countries.TotalPages,
                countries.HasNext,
                countries.HasPrevious,
                countries.PageSize,
                countries.TotalCount
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetCountry(int id)
        {
            var country = _uow.Countries.Get(x => x.Id == id);

            var countryDto = _mapper.Map<CountryDto>(country);

            return Ok(countryDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCountry(int id, [FromBody]UpdateCountryDto updateDto)
        {
            try
            {
                var country = _uow.Countries.Get(x => x.Id == id);

                if (country == null)
                {
                    return NotFound("");
                }

                _mapper.Map(updateDto, country);
                _uow.Save();

                return NoContent();
            }
            catch (Exception e)
            {
                // TODO: logowanie błędów
                throw;
            }
            
        }
    }
}
