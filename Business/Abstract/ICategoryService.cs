using Entities;

namespace Business.Abstract;

public interface ICategoryService
{
    Task<IQueryable<Category>> GetAllAsync();
    Task<Category> GetByIdAsync(int id);
    Task<Category> AddAsync(Category category);
    Task<Category> UpdateAsync(Category category);
    Task<Category> DeleteAsync(int id);
}

