using Core.Entities;

namespace Entities;

public class Broadcast:IEntity
{
    public int Id { get; set; }
    public int ChannelId { get; set; }
    public string StartTime { get; set; }
    public string? EndTime { get; set; }
  

   
}
