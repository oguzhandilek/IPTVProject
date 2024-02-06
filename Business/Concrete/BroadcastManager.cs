using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class BroadcastManager : IBroadcastService
{
    private readonly IBroadcastDal _broadcastDal;

    public BroadcastManager(IBroadcastDal broadcastDal)
    {
        _broadcastDal = broadcastDal;
    }

    public async Task<Broadcast> AddAsync(Broadcast broadcast)
    {
         await _broadcastDal.AddAsync(broadcast);
         return null;
    }

    public async Task<Broadcast> DeleteAsync(int id)
    {
       await _broadcastDal.DeleteAsync(id);
        return null;

    }

    public async Task<IQueryable<Broadcast>> GetAllAsync()
    {
        return await _broadcastDal.GetAllAsync(); 
    }

    public async Task<Broadcast> GetByIdAsync(int id)
    {
        return await _broadcastDal.GetAsync(p=>p.Id == id);

    }

    public async Task<Broadcast> UpdateAsync(Broadcast broadcast)
    {
        await _broadcastDal.UpdateAsync(broadcast);
        return null;
    }
}

