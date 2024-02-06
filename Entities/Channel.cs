using Core.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;

public class Channel:IEntity
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int ChannelTypeId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Url { get; set; }

}

