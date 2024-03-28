using Blood_Bank.Core.Entities;
using Blood_Bank.Core.Repositories;
using Blood_Bank.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Service
{
    public class SicksService : ISicksService
    {
        private readonly ISicksRepositories _sicksRepositories;
        public SicksService(ISicksRepositories sicksRepositories)
        {
            _sicksRepositories = sicksRepositories;
        }
        public async Task<List<Sicks>> GetAllSicksAsync()
        {
            return await _sicksRepositories.GetAllSicksAsync();
        }
        public async Task<Sicks> GetSickByIdAsync(int id)
        {
            return await _sicksRepositories.GetSickByIdAsync(id);

        }

        public async Task AddSickAsync(Sicks sic)
        {
           await _sicksRepositories.AddSickAsync(sic);

        }


        public async Task UpdateSickAsync(int id, Sicks sic)
        {
          await _sicksRepositories.UpdateSickAsync(id, sic);
        }


        public async Task DeleteSickAsync(int id)
        {
           await _sicksRepositories.DeleteSickAsync(id);

        }
    }
}

