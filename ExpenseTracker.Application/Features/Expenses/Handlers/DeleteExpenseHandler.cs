using ExpenseTracker.Application.Features.Expenses.Commands;
using ExpenseTracker.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Application.Features.Expenses.Handlers
{
    public class DeleteExpenseHandler
    {
        private readonly IExpenseRepository _expenseRepository;

        public DeleteExpenseHandler(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public async Task Handle(DeleteExpenseCommand request) { 

            var expense = await _expenseRepository.GetById(request.ExpenseId);

            if (expense == null)
                throw new Exception("Expense does not exist!");

            await _expenseRepository.Delete(request.ExpenseId);
        }
    }
}
