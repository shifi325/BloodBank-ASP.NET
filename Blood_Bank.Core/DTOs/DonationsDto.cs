using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core.DTOs
{
    public class DonationsDto
    {
        public int Id { get; set; }
        public int idSick { get; set; }
        public int idDonor { get; set; }
     
        public int statusDonation { get; set; }
    }
}
