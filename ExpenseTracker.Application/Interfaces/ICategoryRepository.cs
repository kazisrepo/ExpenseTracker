using ExpenseTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Application.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        // specific to this class
    }
}
