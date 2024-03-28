using Blood_Bank.Core.Entities;
using Blood_Bank.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Data.Repositories
{
    public class SicksReposotory : ISicksRepositories
    {
        private readonly DataContext _context;
        public SicksReposotory(DataContext context)
        {
            _context = context;
        }


        public async Task<List<Sicks>> GetAllSicksAsync()
        {
            return await _context.SicksList.ToListAsync();
        }

        public async Task<Sicks> GetSickByIdAsync(int id)
        {
            return await _context.SicksList.FindAsync(id);

        }
        public async Task AddSickAsync(Sicks sic)
        {
            _context.SicksList.Add(sic);
           await _context.SaveChangesAsync();
           
        }

        public async Task UpdateSickAsync(int id, Sicks sic)
        {
            var sic2 = GetSickByIdAsync(id).Result;
            if (sic2 != null) { 
            sic2.fNameSick = sic.fNameSick;
            sic2.lNameSick = sic.lNameSick;
            sic2.typeBloodSick = sic.typeBloodSick;
            sic2.pelephoneSick = sic.pelephoneSick;
            sic2.statusSick = sic.statusSick;
            await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteSickAsync(int id)
        {
            var sic1 = GetSickByIdAsync(id);
            _context.SicksList.Remove(sic1.Result);
           await _context.SaveChangesAsync();

        }
    }
}
