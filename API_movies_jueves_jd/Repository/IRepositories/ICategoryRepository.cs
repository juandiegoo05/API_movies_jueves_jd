using API_movies_jueves_jd.DAL.Models;

namespace API_movies_jueves_jd.Repository.iRepositories
{
    public interface ICategoryRepository
    {
        Task<ICollection<Category>> GetCategoriesAsync(); // Me retorna una lista de categorias
        Task<Category> GetCategoriesAsync(int Id); // Me retorna una categoria por id
        Task<bool> GetCategoryExistsByIdAsync(int Id); // dice si existe una categoria por id
        Task<bool> GetCategoryExistsByNameAsync(String Name); // si existe una categoria por nombre
        Task<bool> CreateCategoryAsync(Category category); // me crea una categoria
        Task<bool> UpdateCategoryAsync(Category category); // me crea una categoria --- puedo actualizar el nombre y la fecha de actualizacion
        Task<bool> DeleteCategoryAsync(int Id); // Me elimina una categoria 

    }
}
