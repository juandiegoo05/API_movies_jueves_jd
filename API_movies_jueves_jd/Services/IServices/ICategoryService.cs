using API_movies_jueves_jd.DAL.Models;
using API_movies_jueves_jd.DAL.Models.Dtos;

namespace API_movies_jueves_jd.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDto>> GetCategoriesAsync(); 
        Task<CategoryDto> GetCategoriesAsync(int Id); 
        Task<bool> GetCategoryExistsByIdAsync(int Id); 
        Task<bool> GetCategoryExistsByNameAsync(String Name);
        Task<bool> CreateCategoryAsync(Category category); 
        Task<bool> UpdateCategoryAsync(Category category); 
        Task<bool> DeleteCategoryAsync(int Id); 
    }
}
