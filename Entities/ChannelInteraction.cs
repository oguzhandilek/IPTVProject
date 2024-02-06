using Core.Entities;

namespace Entities;

public class ChannelInteraction:IEntity 
{
    //Etkileşim özellikleri
    public int Id { get; set; }
    public int ChannelId { get; set; }
    public int Likes { get; set; }
    public int Dislikes { get; set; }
    public int Views { get; set; }
  
}

