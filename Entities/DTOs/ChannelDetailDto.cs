using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs;

public class ChannelDetailDto
{
    public string ChannelTypeName { get; set; } //Tematik, Canlı,TV,Radyo,Youtube
    public string ChannelCategoryName { get; set; } //Eğitim, Spor, Haber
    public string ChannelName { get; set; } // TRT1, TrtHaber
    public string? Description { get; set; } 
    public int Likes { get; set; }
    public int Dislikes { get; set; }
    public int Views { get; set; }
  

}
