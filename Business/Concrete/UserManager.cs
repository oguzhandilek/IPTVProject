using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete;

public class UserManager : IUserService
{
    private readonly IUserDal _userDal;

    public UserManager(IUserDal userDal)
    {
        _userDal = userDal;
    }

    public async Task<User> AddAsync(User user)
    {
       await _userDal.AddAsync(user);
        return null;
    }

    public async Task<User> DeleteAsync(int id)
    {
      await _userDal.DeleteAsync(id);
        return null;
    }

    public async Task<IQueryable<User>> GetAllAsync()
    {
       return await _userDal.GetAllAsync();
    }

    public async Task<User> GetByIdAsync(int id)
    {
      return await _userDal.GetAsync(p=>p.Id == id);
    }

    public async Task<User> UpdateAsync(User user)
    {
        await _userDal.UpdateAsync(user);
        return null;
    }
}

