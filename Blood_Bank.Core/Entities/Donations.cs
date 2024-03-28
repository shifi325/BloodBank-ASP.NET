using System.ComponentModel.DataAnnotations;

namespace Blood_Bank.Core.Entities
{
    public class Donations:BaseModel
    {
      
        public int idSick { get; set; }
        public Sicks Sick { get; set; }
        public int idDonor { get; set; }
        public Donors Donor { get; set; }
        public int statusDonation { get; set; }
    }
}
