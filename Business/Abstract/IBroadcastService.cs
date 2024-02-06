using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IBroadcastService
{
   Task<IQueryable<Broadcast>> GetAll();
    Task<Broadcast> GetByIdAsync(int id);
    Task<Broadcast> AddAsync(Broadcast broadcast);
    Task<Broadcast> UpdateAsync(Broadcast broadcast);
    Task<Broadcast> DeleteAsync(int id);

}

