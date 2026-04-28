using ExpenseTracker.Application.Features.Expenses.Commands;
using ExpenseTracker.Application.Interfaces;
using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Factories;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExpenseTracker.Application.Features.Expenses.Handlers
{
    public class CreateExpenseHandler
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly IExpenseFactory _expenseFactory;

        public CreateExpenseHandler(IExpenseRepository expenseRepository, IExpenseFactory expenseFactory)
        {
            _expenseRepository = expenseRepository;
            _expenseFactory = expenseFactory;
        }

        public async Task Handle(CreateExpenseCommand request)
        {
            var expense = _expenseFactory.Create(request.Amount, request.Description, request.TaxStatus, request.UserId, request.CategoryId);
            await _expenseRepository.Add(expense);
        }


    }
}
