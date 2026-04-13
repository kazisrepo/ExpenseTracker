using ExpenseTracker.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Domain.Entities
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public TaxDeductibilityStatus TaxStatus { get; set; }

        public Expense(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount must be greater than 0. ");
            }
        }
    }
}
