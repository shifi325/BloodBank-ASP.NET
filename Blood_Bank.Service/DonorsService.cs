using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blood_Bank.Data.Repositories;
using Blood_Bank.Core.Repositories;
using Blood_Bank.Core.Services;

namespace Blood_Bank.Service
{
    public class DonorsService : IDonorsService
    {
        private readonly IDonorsRepositories _donorsRepositories;
        public DonorsService(IDonorsRepositories donorsRepositories)
        {
            _donorsRepositories = donorsRepositories;
        }
        public async Task<List<Donors>> GetAllDonorsAsync()
        {
            return await _donorsRepositories.GetAllDonorsAsync();
        }
        public async Task<Donors> GetDonorByIdAsync(int id)
        {
            return await _donorsRepositories.GetDonorByIdAsync(id);

        }

        public async Task AddDonorAsync(Donors don)
        {
         await  _donorsRepositories.AddDonorAsync(don);

        }


        public async Task UpdateDonorAsync(int id, Donors don)
        {
           await _donorsRepositories.UpdateDonorAsync(id, don);
        }


        public async Task DeleteDonorAsync(int id)
        {
           await _donorsRepositories.DeleteDonorAsync(id);

        }
    }
}

