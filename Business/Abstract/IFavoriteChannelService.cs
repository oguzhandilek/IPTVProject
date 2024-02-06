using Entities;

namespace Business.Abstract;

public interface IFavoriteChannelService
{
    Task<IQueryable<FavoriteChannel>> GetAllAsync();
    Task<FavoriteChannel> GetByIdAsync(int id);
    Task<FavoriteChannel> AddAsync(FavoriteChannel favoriteChannel);
    Task<FavoriteChannel> UpdateAsync(FavoriteChannel favoriteChannel);
    Task<FavoriteChannel> DeleteAsync(int id);

}

