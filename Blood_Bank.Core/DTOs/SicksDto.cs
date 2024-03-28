using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core.DTOs
{
    public class SicksDto
    {
        public int Id { get; set; }
        public string? fNameSick { get; set; }
        public string? lNameSick { get; set; }
        public string? typeBloodSick { get; set; }
        public string? pelephoneSick { get; set; }
        public int statusSick { get; set; }
    }
}
