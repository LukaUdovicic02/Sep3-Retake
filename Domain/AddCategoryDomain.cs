﻿using Domain.Interfaces;
using Entity;

namespace Domain
{
    public class AddCategoryDomain : IAddCategoryDomain
    {
        private ICategoryRepo CategoryRepo;
        
        public void Execute(Category category)
        {
            CategoryRepo.AddCategory(category);
        }

        public AddCategoryDomain(ICategoryRepo categoryRepo)
        {
            CategoryRepo = categoryRepo;
        }
    }
}