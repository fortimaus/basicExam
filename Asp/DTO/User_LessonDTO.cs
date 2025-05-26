using Asp.DataBase.Models;

namespace Asp.DTO
{
    public class User_LessonDTO
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public int lessonId { get; set; }
        public string date { get; set; } = string.Empty;
        public string userName { get; set; } = string.Empty;
        public string lessonTitle { get; set; } = string.Empty;
        public string lessonDesc { get; set; } = string.Empty;

    }
}
