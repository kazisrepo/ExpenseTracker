using ExpenseTracker.Application.Features.Categories.Commands;
using ExpenseTracker.Application.Interfaces;
using ExpenseTracker.Domain.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Application.Features.Categories.Handlers
{
    public class CreateCategoryHandler
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICategoryFactory _categoryFactory;
        public CreateCategoryHandler(ICategoryRepository categoryRepository, ICategoryFactory categoryFactory)
        {
            _categoryRepository = categoryRepository;  
            _categoryFactory = categoryFactory;
        }

        public async Task Handle(CreateCategoryCommand request) 
        {
            var category = _categoryFactory.Create(request.CategoryName, request.IsActive);
            await _categoryRepository.Add(category);
        }
    }
}
