using AutoMapper;
using Blood_Bank.Core.DTOs;
using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<Donations, DonationsDto>().ReverseMap();
            CreateMap<Donors, DonorsDto>().ReverseMap();
            CreateMap<Sicks, SicksDto>().ReverseMap();
        }
    }
}
