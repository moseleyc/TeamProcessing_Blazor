using System;
using System.ComponentModel.DataAnnotations;

namespace ManagedAccountClasses.TeamSite
{
    public class SpecialInstruction
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string Notes { get; set; }
        public string EnteredBy { get; set; }

        [DataType(DataType.Text)]
        public DateTime EnteredDate { get; set; }
    }
}
