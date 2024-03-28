using AutoMapper;
using Blood_Bank.Core.Entities;
using Blood_Bank.Models;
namespace Blood_Bank
{
    public class APIMappingProfile:Profile
    {
        public APIMappingProfile()
        {
            
            CreateMap<DonationsModel, Donations>();
            CreateMap<DonorsModel, Donors>();
            CreateMap<SicksModel, Sicks>();
        }
    }
}
