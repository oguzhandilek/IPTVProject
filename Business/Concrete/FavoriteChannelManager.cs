using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete;

public class FavoriteChannelManager : IFavoriteChannelService
{
    private readonly IFavoriteChannelDal _favoriteChannelDal;

    public FavoriteChannelManager(IFavoriteChannelDal favoriteChannelDal)
    {
        _favoriteChannelDal = favoriteChannelDal;
    }

    public async Task<FavoriteChannel> AddAsync(FavoriteChannel favoriteChannel)
    {
       await _favoriteChannelDal.AddAsync(favoriteChannel);
        return null;
    }

    public async Task<FavoriteChannel> DeleteAsync(int id)
    {
        await _favoriteChannelDal.DeleteAsync(id);
        return null;
    }

    public async Task<IQueryable<FavoriteChannel>> GetAllAsync()
    {
        return await _favoriteChannelDal.GetAllAsync();
    }

    public async Task<FavoriteChannel> GetByIdAsync(int id)
    {
        return await _favoriteChannelDal.GetAsync(p=> p.Id == id);
    }

    public async Task<FavoriteChannel> UpdateAsync(FavoriteChannel favoriteChannel)
    {
        await _favoriteChannelDal.UpdateAsync(favoriteChannel);
        return null;
    }
}

