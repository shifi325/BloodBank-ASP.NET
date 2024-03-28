using Blood_Bank.Core.Entities;

namespace Blood_Bank.Models
{
    public class DonationsModel
    {
        public int idSick { get; set; }
        public int idDonor { get; set; }
        public int statusDonation { get; set; }
    }
}
