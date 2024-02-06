using Entities;

namespace Business.Abstract;

public interface IChannelTypeService
{
    Task<IQueryable<ChannelType>> GetAllAsync();
    Task<ChannelType> GetByIdAsync(int id);
    Task<ChannelType> AddAsync(ChannelType channelType);
    Task<ChannelType> UpdateAsync(ChannelType channelType);
    Task<ChannelType> DeleteAsync(int id);
}

