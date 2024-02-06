using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework;

public class IPTVContext:DbContext
{
    public DbSet<Broadcast> Broadcasts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Channel> Channels { get; set; }
    public DbSet<ChannelInteraction>  ChannelInteractions { get; set; }
    public DbSet<ChannelType> ChannelTypes { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<FavoriteChannel> FavoriteChannels { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("PostgreSQL_Connection"));

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        // Channel - Category ilişkisi
        modelBuilder.Entity<Channel>()
            .HasOne(c => c.Category)                  // Her bir Channel, bir Category'ye ait olacak
            .WithMany()                              // Her bir Category'nin birden fazla Channel'i olabilir
            .HasForeignKey(c => c.CategoryId)       // Foreign key olarak CategoryId kullanılacak
            .OnDelete(DeleteBehavior.Restrict)      // Kategori silindiğinde bu kategorinin bağlı olduğu kanalları silme (Opsiyonel, gerektiğine göre değiştirilebilir)
            .IsRequired();                           // CategoryId zorunlu bir alan, yani her bir Channel mutlaka bir kategoriye ait olmalı

        // Diğer ilişki tanımlamaları
        modelBuilder.Entity<ChannelType>()
            .HasMany(ct => ct.Categories)            // Bir ChannelType'in birden fazla Category'si olabilir
            .WithOne(c => c.ChannelType)             // Her bir Category, bir ChannelType'a ait olacak
            .HasForeignKey(c => c.ChannelTypeId)    // Foreign key olarak ChannelTypeId kullanılacak
            .OnDelete(DeleteBehavior.Restrict)      // ChannelType silindiğinde bağlı olduğu Category'leri silme (Opsiyonel, gerektiğine göre değiştirilebilir)
            .IsRequired();                           // ChannelTypeId zorunlu bir alan, yani her bir Category mutlaka bir ChannelType'a ait olmalı

       
    }

}
