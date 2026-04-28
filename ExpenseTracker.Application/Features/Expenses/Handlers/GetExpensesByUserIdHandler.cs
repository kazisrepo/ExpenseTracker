using ExpenseTracker.Application.Features.Expenses.Queries;
using ExpenseTracker.Application.Interfaces;
using ExpenseTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Application.Features.Expenses.Handlers
{
    public class GetExpensesByUserIdHandler
    {
        private readonly IExpenseRepository _expenseRepository;
        public GetExpensesByUserIdHandler(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository; 
        }

        public async Task<List<Expense>> Handle(GetExpenseByUserIdQuery request) {

            return await _expenseRepository.GetAllByUserId(request.UserId);
        }
    }
}
