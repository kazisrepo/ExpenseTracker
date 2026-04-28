using ExpenseTracker.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Application.Features.Expenses.Commands
{
    public class CreateExpenseCommand
    {
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public TaxDeductibilityStatus TaxStatus { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
    }
}
