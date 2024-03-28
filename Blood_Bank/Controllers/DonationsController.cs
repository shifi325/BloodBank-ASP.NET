using Microsoft.AspNetCore.Mvc;
using Blood_Bank.Core.Entities;
using Microsoft.Extensions.Options;
using Blood_Bank.Service;
using Blood_Bank.Core.Services;
using Blood_Bank.Models;
using AutoMapper;
using Blood_Bank.Core.DTOs;
using Blood_Bank.Data;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blood_Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationsController : ControllerBase
    {
        
        private readonly IDonationsService _donationsService;
        private readonly DataContext _context;

        private readonly IMapper _mapper;
        public DonationsController(DataContext context,IDonationsService donationsService, IMapper mapper)
        {
            _mapper = mapper;
            _donationsService = donationsService;
            _context = context;
        }
       
        // GET: api/<DonationsController>
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var lst = await _donationsService.GetAllDonationsAsync();
            var lstDto=new List<DonationsDto>();
            foreach(var item in lst)
            {
                lstDto.Add(_mapper.Map<DonationsDto>(item));
            }
            return Ok(lstDto);
        }

        // GET api/<DonationsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var donations = _donationsService.GetDonationByIdAsync(id);
            if(donations == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DonationsDto>(donations));
        }

        // POST api/<DonationsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DonationsModel dona)
        {
            var donor = _context.DonorsList.First(d => d.Id == dona.idDonor);
            var sick = _context.SicksList.First(u => u.Id == dona.idSick);
            var donationPost = new Donations { idDonor = dona.idDonor, idSick = dona.idSick, statusDonation = dona.statusDonation };
            donationPost.Sick = sick;
            donationPost.Donor=donor;
           await _donationsService.AddDonationAsync(donationPost);
            _mapper.Map(dona, donationPost);
            return Ok(_mapper.Map<DonationsDto>(donationPost) );

        }

        // PUT api/<DonationsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Donations dona)
        {
            var donat=await _donationsService.GetDonationByIdAsync(id);
            if(donat is null)
            {
                return NotFound();
            }
            _mapper.Map(dona, donat);
            await _donationsService.UpdateDonationAsync(id, dona);
            return Ok();
        }

        // DELETE api/<DonationsController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            
          await _donationsService.DeleteDonationAsync(id);
        }
    }
}
