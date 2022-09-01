using System;
using System.Collections.Generic;

namespace BankApp.Data.Scaffolded
{
    public partial class AccountDb
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public decimal Balance { get; set; }
        public decimal Withdrawn { get; set; }
        public decimal PaidIn { get; set; }
    }
}
