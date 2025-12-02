using API_movies_jueves_jd.DAL.Models;
using API_movies_jueves_jd.DAL.Models.Dtos;
using API_movies_jueves_jd.Repository.iRepositories;
using API_movies_jueves_jd.Services.IServices;
using AutoMapper;

namespace API_movies_jueves_jd.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public Task<bool> CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCategoryAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<CategoryDto>> GetCategoriesAsync()
        {
            var categories = await _categoryRepository.GetCategoriesAsync(); // solo se llama el metodo desde la capa de repo

            return _mapper.Map<ICollection<CategoryDto>>(categories); // mapeo la lista de categorias a una lista de Dto
        }

        public Task<CategoryDto> GetCategoriesAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetCategoryExistsByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetCategoryExistsByNameAsync(string Name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
