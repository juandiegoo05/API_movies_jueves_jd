using API_movies_jueves_jd.DAL;
using API_movies_jueves_jd.DAL.Models;
using API_movies_jueves_jd.Repository.iRepositories;
using Microsoft.EntityFrameworkCore;

namespace API_movies_jueves_jd.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _Context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _Context = context;
        }

        public async Task<bool> CreateCategoryAsync(Category category)
        {
            category.CreateDate = DateTime.UtcNow;

            await _Context.Categories.AddAsync(category);

            return await SaveAsync();
        }

        public async Task<bool> DeleteCategoryAsync(int Id)
        {
            var category = await GetCategoriesAsync(Id); // se consulta que si exista

            if (category == null)
            {
                return false; // la categoria no exixte
            }

            _Context.Categories.Remove(category);
            return await SaveAsync();
        }

        public async Task<ICollection<Category>> GetCategoriesAsync()
        {
            return await _Context.Categories
               .AsNoTracking()
               .OrderBy(c => c.Name)
               .ToListAsync();
        }

        public async Task<Category> GetCategoriesAsync(int Id) // async y await
        {
            return await _Context
                .Categories
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == Id); //lambda expressions
        }

        public async Task<bool> GetCategoryExistsByIdAsync(int Id)
        {
            return await _Context.Categories
               .AsNoTracking()
               .AnyAsync(c => c.Id == Id);
        }

        public async Task<bool> GetCategoryExistsByNameAsync(string Name)
        {
            return await _Context.Categories
               .AsNoTracking()
               .AnyAsync(c => c.Name == Name);
        }

        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            category.ModifiedDate = DateTime.UtcNow;

            _Context.Categories.Update(category);

            return await SaveAsync();
        }

        private async Task<bool> SaveAsync()
        {
            return await _Context.SaveChangesAsync() >= 0 ? true : false;
        } 

    }
}
