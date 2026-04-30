using ExpenseTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Domain.Factories
{
    public interface ICategoryFactory
    {
        Category Create(string categoryName, bool isActive);
    }
}
