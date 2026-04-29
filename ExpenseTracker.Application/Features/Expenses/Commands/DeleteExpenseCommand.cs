using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Application.Features.Expenses.Commands
{
    public class DeleteExpenseCommand
    {
        public int ExpenseId { get; set; }
    }
}
