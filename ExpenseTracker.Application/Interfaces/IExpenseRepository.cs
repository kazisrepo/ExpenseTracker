using ExpenseTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Application.Interfaces
{
    public interface IExpenseRepository
    {
        Task Add(Expense expense);
        Task Edit(Expense expense);
        Task Delete(int expenseId);
        Task<List<Expense>> GetAllByUserId(int userId);
        Task<Expense?> GetById(int expenseId);

    }
}
