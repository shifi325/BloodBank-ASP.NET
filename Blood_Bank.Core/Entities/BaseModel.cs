using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Core.Entities
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }

        //public DateTime CreatedAt { get; set; }

        //public int CreatedBy { get; set; }

        //public DateTime UpdatedAt { get; set; }

        //public int UpdatedBy { get; set; }
    }
}
