using System.ComponentModel.DataAnnotations;

namespace Blood_Bank.Core.Entities
{
    public class Sicks:BaseModel
    {
        public string? fNameSick { get; set; }
        public string? lNameSick { get; set; }
        public string? typeBloodSick { get; set; }
        public string? pelephoneSick { get; set; }
        public int statusSick { get; set; }
        public List<Donations> donations { get; set; }

    }
}
