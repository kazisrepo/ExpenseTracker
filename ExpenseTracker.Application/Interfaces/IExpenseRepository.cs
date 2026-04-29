using ExpenseTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Application.Interfaces
{
    public interface IExpenseRepository : IGenericRepository<Expense>
    {
        Task<List<Expense>> GetAllByUserId(int userId);
    }
}
