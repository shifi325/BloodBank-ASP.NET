using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blood_Bank.Core.Entities;
using Blood_Bank.Core.Repositories;
using Blood_Bank.Core.Services;
using Blood_Bank.Data;

namespace Blood_Bank.Service
{
    public class DonationsService : IDonationsService
    {
        private readonly IDonationsRepositories _donationsRepositories;
        public DonationsService(IDonationsRepositories donationsRepositories)
        {
            _donationsRepositories = donationsRepositories;
        }
        public async Task<List<Donations>> GetAllDonationsAsync()
        {
            return await _donationsRepositories.GetAllDonationsAsync();
        }
        public async Task<Donations> GetDonationByIdAsync(int id)
        {
            return await _donationsRepositories.GetDonationByIdAsync(id);

        }

        public async Task AddDonationAsync(Donations dona)
        {
            await _donationsRepositories.AddDonationAsync(dona);

        }


        public async Task UpdateDonationAsync(int id, Donations dona)
        {
          await  _donationsRepositories.UpdateDonationAsync(id, dona);
        }


        public async Task DeleteDonationAsync(int id)
        {
           await _donationsRepositories.DeleteDonationAsync(id);

        }
    }
}
