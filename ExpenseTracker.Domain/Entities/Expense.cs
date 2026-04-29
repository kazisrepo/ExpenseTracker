using ExpenseTracker.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Domain.Entities
{
    public class Expense : BaseEntity
    {
        public decimal Amount { get; set; }
        public string? Description { get; set; } 
        public TaxDeductibilityStatus TaxStatus { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

    }
}
