using EcommerceProject.Shared;
using System.Collections.Generic;

namespace EcommerceProject.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();
    }
}
