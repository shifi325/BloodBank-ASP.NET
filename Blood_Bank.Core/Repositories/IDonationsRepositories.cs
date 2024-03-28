using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core.Repositories
{
    public interface IDonationsRepositories
    {
        public Task<List<Donations>> GetAllDonationsAsync();
        public Task<Donations> GetDonationByIdAsync(int id);
        public Task AddDonationAsync(Donations dona);
        public Task UpdateDonationAsync(int id, Donations dona);
       public Task DeleteDonationAsync(int id);

    }
}
