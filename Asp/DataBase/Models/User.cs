using Asp.DataBase.Enums;
using Asp.DTO;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Asp.DataBase.Models
{
    public class User
    {
        public int Id { get; set; }
        public string login { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public UserRole role { get; set; }
        [ForeignKey("trainingId")]
        public int? trainingId { get; set; }
        public virtual Training? training { get; set; } = new();
        public virtual List<User_Lesson> Lessons { get; set; } = new();
        public UserDto getDto()
        {
            return new UserDto()
            {
                Id = Id,
                login = login,
                password = password,
                role = role,
                trainingId = training.Id,
                trainingTitle = training.title
            };
        }
    }
}
