using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete;

public class ChannelManager : IChannelService
{
    private readonly IChannelDal _channelDal;

    public ChannelManager(IChannelDal channelDal)
    {
        _channelDal = channelDal;
    }

    public async Task<Channel> AddAsync(Channel channel)
    {
        await _channelDal.AddAsync(channel);
        return null;
    }

    public async Task<Channel> DeleteAsync(int id)
    {
       await _channelDal.DeleteAsync(id);
        return null;
    }

    public async Task<IQueryable<Channel>> GetAllAsync()
    {
        return await _channelDal.GetAllAsync();
    }

    public async Task<Channel> GetByIdAsync(int id)
    {
       return await _channelDal.GetAsync(p=>p.Id == id);
    }

    public async Task<Channel> UpdateAsync(Channel channel)
    {
        await _channelDal.UpdateAsync(channel);
        return null;
    }
}

