using ExpenseTracker.Application.Features.Categories.Commands;
using ExpenseTracker.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Application.Features.Categories.Handlers
{
    public class UpdateCategoryHandler
    {
        private readonly ICategoryRepository _categoryRepository;
        public UpdateCategoryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task Handle(UpdateCategoryCommand request) { 

            var category =  await _categoryRepository.GetById(request.CategoryId);
            if (category == null)
                throw new Exception("Category doesnt exist");

            category.CategoryName = request.CategoryName;
            category.IsActive = request.IsActive;

            await _categoryRepository.Update(category);
        }
    }
}
