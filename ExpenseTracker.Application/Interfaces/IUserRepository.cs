using ExpenseTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Application.Interfaces
{
    public interface IUserRepository
    {
        Task Add(User user);
        Task Edit(User user);
        Task Delete(int userId);
        Task<User?> GetById(int userId);
    }
}
