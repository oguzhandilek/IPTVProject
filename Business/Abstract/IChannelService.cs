using Entities;

namespace Business.Abstract;

public interface IChannelService
{
    Task<IQueryable<Channel>> GetAll();
    Task<Channel> GetByIdAsync(int id);
    Task<Channel> AddAsync(Channel channel);
    Task<Channel> UpdateAsync(Channel channel);
    Task<Channel> DeleteAsync(int id);
}

