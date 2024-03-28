using Blood_Bank.Core.Entities;
using Blood_Bank.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Blood_Bank.Data.Repositories
{
    public class DonationsReposotory : IDonationsRepositories
    {
        private readonly DataContext _context;
        public DonationsReposotory(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Donations>> GetAllDonationsAsync()
        {
            return await _context.DonationsList.ToListAsync();
        }
        public async Task<Donations> GetDonationByIdAsync(int id)
        {
            return await _context.DonationsList.FindAsync(id);

        }

        public async Task AddDonationAsync(Donations dona)
        {
            _context.DonationsList.Add(dona);
           await _context.SaveChangesAsync();
        }


        public async Task UpdateDonationAsync(int id, Donations dona)
        {
            var dona2 = GetDonationByIdAsync(id).Result;
            if (dona2 != null) {
               dona2.idDonor=dona.idDonor;
                dona2.idSick=dona.idSick;
                dona2.statusDonation = dona.statusDonation;
               await _context.SaveChangesAsync();
            }
            
        }
        

        


        public async Task DeleteDonationAsync(int id)
        {
          var dona1 = GetDonationByIdAsync(id);
            _context.DonationsList.Remove(dona1.Result);
           await _context.SaveChangesAsync();

        }
    }
}
