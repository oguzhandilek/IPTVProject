using Core.Entities;

namespace Entities;

public class ChannelInteraction:IEntity
{
    public int Id { get; set; }
    public int ChannelId { get; set; }
    public int Likes { get; set; }
    public int Dislikes { get; set; }
    public int Views { get; set; }
    public List<Comment> Comments { get; set; }
}

