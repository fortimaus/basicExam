using Asp.DataBase.Enums;
using Asp.DataBase.Models;

namespace Asp.DTO
{
    public class UserDto
    {
        public int Id { get; set; }
        public string login { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        
        public UserRole role { get; set; }
        public int? trainingId { get; set; }

        public string trainingTitle { get; set; } = string.Empty;

        
    }
}
