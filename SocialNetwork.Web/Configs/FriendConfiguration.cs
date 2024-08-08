using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Web.Models.Users;

namespace SocialNetwork.Web.Configs
{
    public class FriendConfiguration : IEntityTypeConfiguration<Friend>
    {

        public void Configure(EntityTypeBuilder<Friend> builder)
        {
            builder.ToTable("UserFriends").HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
