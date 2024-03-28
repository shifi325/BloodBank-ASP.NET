using Blood_Bank.Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace Blood_Bank.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Donors> DonorsList { get; set; }
        public DbSet<Donations> DonationsList { get; set; }
        public DbSet<Sicks> SicksList { get; set; }
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BloodBank-DB");
        }
        //public DataContext()
        //{
        //    DonorsList = new List<Donors>();
        //    DonorsList.Add(new Donors { idDonor = 1, fNameDonor = "giti", lNameDonor = "knep", typeBloodDonor = "A", pelephoneDonor = "0558715857", statusDonor = 1 });
        //    DonationsList = new List<Donations>();
        //    DonationsList.Add(new Donations { idDonation = 2, idDonor =1 ,idSick=3,statusDonation=2 });
        //    SicksList = new List<Sicks>();
        //    SicksList.Add(new Sicks { idSick = 1, fNameSick = "giti", lNameSick = "knep", typeBloodSick = "A", pelephoneSick = "0555824857", statusSick = 1 });

        //}
    }
}
