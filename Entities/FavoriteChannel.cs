using Core.Entities;

namespace Entities;

public class FavoriteChannel:IEntity
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ChannelId { get; set; }
    public int ChannelCategoryId { get; set; }
    public DateTime AddedAt { get; set; }


}
