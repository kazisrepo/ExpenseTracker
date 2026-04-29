using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
