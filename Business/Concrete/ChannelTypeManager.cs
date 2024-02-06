using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete;

public class ChannelTypeManager : IChannelTypeService
{
    private readonly IChannelTypeDal _channelTypeDal;

    public ChannelTypeManager(IChannelTypeDal channelTypeDal)
    {
        _channelTypeDal = channelTypeDal;
    }

    public async Task<ChannelType> AddAsync(ChannelType channelType)
    {
        await _channelTypeDal.AddAsync(channelType);
        return null;
    }

    public async Task<ChannelType> DeleteAsync(int id)
    {
      await _channelTypeDal.DeleteAsync(id);
        return null;
    }

    public async Task<IQueryable<ChannelType>> GetAllAsync()
    {
       return await _channelTypeDal.GetAllAsync();
    }

    public async Task<ChannelType> GetByIdAsync(int id)
    {
       return await _channelTypeDal.GetAsync(p=>p.Id == id);

    }

    public async Task<ChannelType> UpdateAsync(ChannelType channelType)
    {
        await _channelTypeDal.UpdateAsync(channelType);
        return null;
    }
}

