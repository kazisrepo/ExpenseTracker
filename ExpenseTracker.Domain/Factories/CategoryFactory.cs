using ExpenseTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Domain.Factories
{
    public class CategoryFactory : ICategoryFactory
    {
        public Category Create(string categoryName, bool isActive)
        {
            return new Category { 
                CategoryName = categoryName,
                IsActive = isActive
            };

            //throw new NotImplementedException();
        }
    }
}
