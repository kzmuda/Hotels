using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Hotels.DataManipulation;
using Hotels.Model;

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
        public IActionResult GetCountries()
        {
            var countries = _uow.Countries.GetAll();

            var result = _mapper.Map<List<CountryDto>>(countries);

            return Ok(countries);
        }

        [HttpGet("{id}")]
        public IActionResult GetCountry(int id)
        {
            var country = _uow.Countries.Get(x => x.Id == id);

            var countryDto = _mapper.Map<CountryDto>(country);

            return Ok(countryDto);
        }
    }
}
