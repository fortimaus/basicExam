using Asp.DTO;

namespace Asp.DataBase.Models
{
    public class Training
    {
        public int Id { get; set; }
        public string title { get; set; } = string.Empty;
        public virtual List<User> users { get; set; } = new();
        public TrainingDTO getDto()
        {
            return new TrainingDTO()
            {
                Id = Id,
                title = title
            };
        }
    }
}
