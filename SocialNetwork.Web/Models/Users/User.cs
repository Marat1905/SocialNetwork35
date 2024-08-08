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
        public string? MiddleName { get; set; }

        /// <summary>Дата рождения</summary>
        public DateTime BirthDate { get; set; }

        public string Image { get; set; }

        public string Status { get; set; }


        public string About { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public User()
        {
            Image = "https://via.placeholder.com/500";
            Status = "Ура! Я в соцсети!";
            About = "Информация обо мне.";
        }
    }
}
