using Core.Entities;

namespace Entities;

public class User:IEntity
{
    public int Id { get; set; }
    public string UserName { get; set; }
    
}

