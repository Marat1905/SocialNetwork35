using SocialNetwork.Data.Models.Users;

namespace SocialNetwork.Web.ViewModels.Account
{
    public class UserWithFriendExt : User
    {
        public bool IsFriendWithCurrent { get; set; }
    }
}
