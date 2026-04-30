using ExpenseTracker.Application.Features.Categories.Commands;
using ExpenseTracker.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Application.Features.Categories.Handlers
{
    public class DeleteCategoryHandler
    {
        private readonly ICategoryRepository _categoryRepository;
        public DeleteCategoryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task Handle(DeleteCategoryCommand request)
        {
            var category = await _categoryRepository.GetById(request.CategoryId);
            if (category == null)
                throw new Exception("Category doesnt exist");
            
            await _categoryRepository.Delete(request.CategoryId);
        
        }

    }
}
