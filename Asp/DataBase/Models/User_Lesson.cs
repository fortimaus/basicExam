using Asp.DTO;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asp.DataBase.Models
{
    public class User_Lesson
    {
        public int Id { get; set; }
        [ForeignKey("userId")]
        public int userId { get; set; }
        [ForeignKey("lessonId")]
        public int lessonId { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
        public virtual User user { get; set; } = new();
        public virtual Lesson lesson { get; set; } = new();
        
        public User_LessonDTO getDto()
        {
            return new User_LessonDTO()
            {
                Id = Id,
                userId = userId,
                userName = user.login,
                lessonId = lessonId,
                lessonDesc = lesson.desc,
                lessonTitle =lesson.title,
                date = date.ToString("dd.MM.yyyy")
            };
        }
    }
}
