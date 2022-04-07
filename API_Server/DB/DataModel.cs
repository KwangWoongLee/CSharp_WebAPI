using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Server.DB
{
    [Table("dat_account")]
    public class AccountDb
    {
        public int Idx { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime RegDt { get; set; }
    }
}
