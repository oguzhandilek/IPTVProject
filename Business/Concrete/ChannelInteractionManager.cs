using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete;

public class ChannelInteractionManager : IChannelInteractionService
{
    private readonly IChannelInteractionDal _channelInteractionDal;

    public ChannelInteractionManager(IChannelInteractionDal channelInteractionDal)
    {
        _channelInteractionDal = channelInteractionDal;
    }

    public async Task<ChannelInteraction> AddAsync(ChannelInteraction channelInteraction)
    {
        await _channelInteractionDal.AddAsync(channelInteraction);
        return null;
    }

    public async Task<ChannelInteraction> DeleteAsync(int id)
    {
       await _channelInteractionDal.DeleteAsync(id);
        return null;
    }

    public async Task<IQueryable<ChannelInteraction>> GetAllAsync()
    {
        return await _channelInteractionDal.GetAllAsync();
    }

    public async Task<ChannelInteraction> GetByIdAsync(int id)
    {
        return await _channelInteractionDal.GetAsync(p=>p.Id == id);
    }

    public async Task<ChannelInteraction> UpdateAsync(ChannelInteraction channelInteraction)
    {
        await _channelInteractionDal.UpdateAsync(channelInteraction);
        return null;
    }
}

