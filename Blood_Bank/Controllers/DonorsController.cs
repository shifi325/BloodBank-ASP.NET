using AutoMapper;
using Blood_Bank.Core.DTOs;
using Blood_Bank.Core.Entities;
using Blood_Bank.Core.Services;
using Blood_Bank.Models;
using Blood_Bank.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blood_Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorsController : ControllerBase
    {
        private readonly IDonorsService _donorsService;
        private readonly IMapper _mapper;
        public DonorsController(IDonorsService donorsService, IMapper mapper)
        {
            _mapper = mapper;
            _donorsService = donorsService;
        }

        // GET: api/<DonationsController>
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var lst = await _donorsService.GetAllDonorsAsync();
            var lstDto=new List<DonorsDto>();
            foreach (var item in lst)
            {
                lstDto.Add(_mapper.Map<DonorsDto>(item));
            }
            return Ok(lstDto);
        }

        // GET api/<DonationsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var dono=await _donorsService.GetDonorByIdAsync(id);
            if(dono == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DonorsDto>(dono));
        }

        // POST api/<DonationsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DonorsModel don)
        {
            var donorPost=new Donors { fNameDonor=don.fNameDonor, lNameDonor=don.lNameDonor, pelephoneDonor=don.pelephoneDonor, statusDonor=don.statusDonor,typeBloodDonor=don.typeBloodDonor };
           await _donorsService.AddDonorAsync(donorPost);
            _mapper.Map(don,donorPost);
            return Ok(_mapper.Map<DonorsDto>(donorPost) );

        }

        // PUT api/<DonationsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Donors don)
        {
            var dono=await _donorsService.GetDonorByIdAsync(id);
            if(dono is null)
            {
                return NotFound();
            }
            _mapper.Map(don,dono);
            await _donorsService.UpdateDonorAsync(id, don);
            return Ok();
        }

        // DELETE api/<DonationsController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {

          await  _donorsService.DeleteDonorAsync(id);
           
        }
    }
}
