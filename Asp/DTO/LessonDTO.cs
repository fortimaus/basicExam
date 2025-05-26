using Asp.DataBase.Models;

namespace Asp.DTO
{
    public class LessonDTO
    {
        public int Id { get; set; }
        public string title { get; set; } = string.Empty;
        public string desc { get; set; } = string.Empty;
        
    }
}
