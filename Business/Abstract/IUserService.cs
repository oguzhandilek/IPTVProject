using Entities;

namespace Business.Abstract;

public interface IUserService
{
    Task<IQueryable<User>> GetAllAsync();
    Task<User> GetByIdAsync(int id);
    Task<User> AddAsync(User user);
    Task<User> UpdateAsync(User user);
    Task<User> DeleteAsync(int id);

}

