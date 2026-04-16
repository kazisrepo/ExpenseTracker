using ExpenseTracker.Application.Expense.Commands;
using ExpenseTracker.Application.Interfaces;
using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Factories;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExpenseTracker.Application.Expense.Handlers
{
    public class CreateExpenseHandler
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly IExpenseFactory _expenseFactory;

        public CreateExpenseHandler(IExpenseFactory expenseFactory)
        {
            _expenseFactory = expenseFactory;
        }

        public async Task Handle(CreateExpenseCommand request)
        {
            var expense = _expenseFactory.Create(request.Amount, request.Description, request.TaxStatus, request.UserId, request.CategoryId);


        }


    }
}
