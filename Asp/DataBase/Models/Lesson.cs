using Asp.DTO;

namespace Asp.DataBase.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string title { get; set; } = string.Empty;
        public string desc { get; set; } = string.Empty;
        public List<User_Lesson> user_Lessons = new();
        public LessonDTO getDto()
        {
            return new LessonDTO()
            {
                Id = Id,
                title = title,
                desc = desc,

            };
        }
    }
}
