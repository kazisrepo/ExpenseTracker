using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Domain.Enums
{
    public enum TaxDeductibilityStatus
    {
        Deductible = 1,
        NonDeductible = 2,
        Uncertain = 3,
    }
}
