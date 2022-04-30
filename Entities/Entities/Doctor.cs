using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Doctor : IEntity
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string birthdate { get; set; }
        public string graduation_date { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
    }
}
