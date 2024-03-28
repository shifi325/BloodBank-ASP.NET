using Blood_Bank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core.Services
{
    public interface ISicksService
    {
        public Task<List<Sicks>> GetAllSicksAsync();
        public Task<Sicks> GetSickByIdAsync(int id);
        public Task AddSickAsync(Sicks sic);
        public Task UpdateSickAsync(int id, Sicks sic);
        public Task DeleteSickAsync(int id);
    }
}
