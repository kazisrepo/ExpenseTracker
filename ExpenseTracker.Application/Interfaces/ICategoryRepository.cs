using ExpenseTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Application.Interfaces
{
    public interface ICategoryRepository
    {
        Task Add(Category category);
        Task Edit(Category category);
        Task Delete(int categoryId);
        Task<Category?> GetById(int categoryId);
        Task<List<Category>> GetAll();
    }
}
