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
    public class DonorsReposotory : IDonorsRepositories
    {
        private readonly DataContext _context;
        public DonorsReposotory(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Donors>> GetAllDonorsAsync()
        {
            return await _context.DonorsList.ToListAsync();

        }

        public async Task<Donors> GetDonorByIdAsync(int id)
        {
            return await _context.DonorsList.FindAsync(id);

        }


        public async Task AddDonorAsync(Donors don)
        {
            _context.DonorsList.Add(don);
            await _context.SaveChangesAsync();
           
        }
        public async Task UpdateDonorAsync(int id, Donors don)
        {
            var don2 = GetDonorByIdAsync(id).Result;
            if (don2 != null)
            {
               
                don2.fNameDonor = don.fNameDonor;
                don2.lNameDonor = don.lNameDonor;
                don2.statusDonor = don.statusDonor;
                don2.pelephoneDonor = don.pelephoneDonor;
                don2.typeBloodDonor = don.typeBloodDonor;
                await _context.SaveChangesAsync();
            } 
        }

        public async Task DeleteDonorAsync(int id)
        {
            var don1 = GetDonorByIdAsync(id);
            _context.DonorsList.Remove(don1.Result);
           await _context.SaveChangesAsync();

        }
    }
}
