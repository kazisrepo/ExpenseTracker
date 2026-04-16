using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ExpenseTracker.Domain.Factories
{
    public class ExpenseFactory : IExpenseFactory
    {
        public Expense Create(decimal amount, string description, TaxDeductibilityStatus status, int userId, int categoryId)
        {
            return new Expense
            {
                Amount = amount,
                Description = description,
                TaxStatus = status,
                UserId = userId,
                CategoryId = categoryId
            };

            //throw new NotImplementedException();
        }
    }
}
