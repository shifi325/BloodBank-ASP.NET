using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core.DTOs
{
   public class DonorsDto
    {
        public int Id { get; set; }
        public string? fNameDonor { get; set; }
        public string? lNameDonor { get; set; }
        public string? typeBloodDonor { get; set; }
        public string? pelephoneDonor { get; set; }
        public int statusDonor { get; set; }
    }
}
