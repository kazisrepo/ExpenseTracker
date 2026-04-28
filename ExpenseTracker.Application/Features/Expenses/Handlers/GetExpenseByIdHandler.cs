using ExpenseTracker.Application.Features.Expenses.Queries;
using ExpenseTracker.Application.Interfaces;
using ExpenseTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ExpenseTracker.Application.Features.Expenses.Handlers
{
    public class GetExpenseByIdHandler
    {
        private readonly IExpenseRepository _expenseRepository;

        public GetExpenseByIdHandler(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public async Task<Expense?> Handle(GetExpenseByIdQuery request) {

            return await _expenseRepository.GetById(request.ExpenseId);
        
        }
    }
}
