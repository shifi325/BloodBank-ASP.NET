using System.ComponentModel.DataAnnotations;

namespace Blood_Bank.Core.Entities
{
    public class Donors:BaseModel
    {
        public string? fNameDonor { get; set; }
        public string? lNameDonor { get; set; }
        public string? typeBloodDonor { get; set; }
        public string? pelephoneDonor { get; set; }
        public int statusDonor { get; set; }
        public List<Donations> donations { get; set; }
    }
}
