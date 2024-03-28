using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core.Services
{
    public interface IDonorsService
    {
        public Task<List<Donors>> GetAllDonorsAsync();
        public Task<Donors> GetDonorByIdAsync(int id);
        public Task AddDonorAsync(Donors don);
        public Task UpdateDonorAsync(int id, Donors don);
        public Task DeleteDonorAsync(int id);
    }
}
