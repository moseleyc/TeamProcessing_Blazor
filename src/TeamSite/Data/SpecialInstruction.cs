using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamSite.Data
{
    public class SpecialInstruction
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string Notes { get; set; }
        public string EnteredBy { get; set; }
        public DateTime EnteredDate { get; set; }
    }
}
