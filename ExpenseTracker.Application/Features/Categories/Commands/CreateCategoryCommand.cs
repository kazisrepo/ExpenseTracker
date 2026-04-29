using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Application.Features.Categories.Commands
{
    public class CreateCategoryCommand
    {
        public string CategoryName { get; set; } = null!;
        // ' = null!; ' -> do not show me warning of null value, i will handle it later
        // ' = string.empty; ' -> ensures default value as an empty string. For a required field this can pass invalid data like an empty string 
        public bool IsActive { get; set; }
    }
}
