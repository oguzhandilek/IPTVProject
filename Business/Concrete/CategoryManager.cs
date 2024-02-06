using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public async Task<Category> AddAsync(Category category)
    {
     await _categoryDal.AddAsync(category);
        return null;
    }

    public async Task<Category> DeleteAsync(int id)
    {
        await _categoryDal.DeleteAsync(id);
        return null;
    }

    public async Task<IQueryable<Category>> GetAllAsync()
    {
       return await _categoryDal.GetAllAsync();
    }

    public async Task<Category> GetByIdAsync(int id)
    {
        return await _categoryDal.GetAsync(p=> p.Id == id);
    }

    public async Task<Category> UpdateAsync(Category category)
    {
        await UpdateAsync(category);
        return null;
    }
}

