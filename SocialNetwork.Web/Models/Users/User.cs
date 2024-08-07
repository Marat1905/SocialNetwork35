using Microsoft.AspNetCore.Identity;

namespace SocialNetwork.Web.Models.Users
{
    public class User: IdentityUser
    {
        /// <summary>Имя</summary>
        public string FirstName { get; set; }

        /// <summary>Фамилия</summary>
        public string LastName { get; set; }

        /// <summary>Отчество</summary>
        public string MiddleName { get; set; }

        /// <summary>Дата рождения</summary>
        public DateTime BirthDate { get; set; }
    }
}
