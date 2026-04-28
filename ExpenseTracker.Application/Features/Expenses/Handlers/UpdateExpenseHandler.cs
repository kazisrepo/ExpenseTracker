using ExpenseTracker.Application.Features.Expenses.Commands;
using ExpenseTracker.Application.Interfaces;
using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Application.Features.Expenses.Handlers
{
    public class UpdateExpenseHandler
    {
        private readonly IExpenseRepository _expenseRepository;

        public UpdateExpenseHandler(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public async Task Handle(UpdateExpenseCommand request) {

            var expense = await _expenseRepository.GetById(request.ExpenseId);

            if (expense == null)
                throw new Exception("Expense not found");

            expense.Amount = request.Amount;
            expense.Description = request.Description;
            expense.TaxStatus = request.TaxStatus;
            expense.UserId = request.UserId;
            expense.CategoryId = request.CategoryId;

            await _expenseRepository.Edit(expense);
        }

    }
}
