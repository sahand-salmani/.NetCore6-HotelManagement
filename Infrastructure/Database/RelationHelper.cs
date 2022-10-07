using Domain.Entities;
using Domain.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database
{
    public class RelationHelper
    {
        public static void AddRelations(ModelBuilder builder)
        {
            // configure relationship for Room and Service
            builder.Entity<RoomService>()
                .HasKey(rs => new { rs.RoomId, rs.ServiceId });

            // configure many to many relation for room and service
            builder.Entity<RoomService>()
                .HasOne(rs => rs.Room)
                .WithMany(r => r.RoomServices)
                .HasForeignKey(rs => rs.RoomId);


            // configure relationship for Room and Image
            builder.Entity<RoomImage>()
                .HasKey(ri => new { ri.RoomId, ri.ImageId });

            // configure many to many relation for room and image
            builder.Entity<RoomImage>()
                .HasOne(ri => ri.Room)
                .WithMany(r => r.RoomImages)
                .HasForeignKey(ri => ri.RoomId);

            // configure relationship for Hotel and Image
            builder.Entity<HotelImage>()
                .HasKey(hi => new { hi.HotelId, hi.ImageId });

            // configure many to many relation for hotel and image
            builder.Entity<HotelImage>()
                .HasOne(hi => hi.Hotel)
                .WithMany(h => h.HotelImages)
                .HasForeignKey(hi => hi.HotelId);


            builder.Entity<ApplicationUserRole>(options =>
            {
                options.HasKey(ur => new { ur.UserId, ur.RoleId });
                options
                    .HasOne(e => e.Role)
                    .WithMany(e => e.Users)
                    .HasForeignKey(e => e.RoleId);
                options.HasOne(e => e.User)
                    .WithMany(e => e.Roles)
                    .HasForeignKey(e => e.UserId);
            });




        }
    }
}
