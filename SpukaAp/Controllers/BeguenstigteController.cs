using Microsoft.AspNetCore.Mvc;
using SpukaAp.Models;
using SpukaAp.Models.DTO;
using SpukaAp.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SpukaAp.Controllers
{

    [Route("api/beguenstigte")]
    [ApiController]


    public class BeguenstigteController: ControllerBase
    {

        private readonly IDataRepository <TBeguenstigte, BeguenstigteDTO> _dataRepository;

        public BeguenstigteController (IDataRepository<TBeguenstigte, BeguenstigteDTO> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/beguenstigte


        [HttpGet]
        public IActionResult Get()
        {
            var beguenstigte = _dataRepository.GetAll();

            return Ok(beguenstigte);
        }

        // GET: api/beguenstigte/5

        [HttpGet("{id}", Name = "Getbeguenstigte")]

        public IActionResult Get(int id)
        {

            var beguenstigte = _dataRepository.GetDto(id);
            if (beguenstigte == null)
            {
                return NotFound("Author not found.");

            }
            return Ok(beguenstigte);
        }


    }
}
