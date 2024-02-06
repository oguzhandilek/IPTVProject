using Entities;

namespace Business.Abstract;

public interface IChannelInteractionService
{
    Task<IQueryable<ChannelInteraction>> GetAll();
    Task<ChannelInteraction> GetByIdAsync(int id);
    Task<ChannelInteraction> AddAsync(ChannelInteraction channelInteraction);
    Task<ChannelInteraction> UpdateAsync(ChannelInteraction channelInteraction);
    Task<ChannelInteraction> DeleteAsync(int id);
}

