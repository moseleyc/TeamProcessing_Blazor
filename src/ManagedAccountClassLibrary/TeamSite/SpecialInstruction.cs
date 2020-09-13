using System;

namespace ManagedAccount.TeamSite
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
