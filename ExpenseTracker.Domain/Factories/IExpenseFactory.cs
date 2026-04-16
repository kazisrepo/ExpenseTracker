using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Domain.Factories
{
    public interface IExpenseFactory
    {
        Expense Create(decimal amount, string description, TaxDeductibilityStatus status, int userId, int categoryId);
    }
}
