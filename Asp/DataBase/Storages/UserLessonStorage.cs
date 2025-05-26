using Asp.DataBase.Models;
using Asp.DTO;
using Microsoft.EntityFrameworkCore;

namespace Asp.DataBase.Storages
{
    public class UserLessonStorage
    {
        readonly int PAGE_SIZE = 5;
        public User_LessonDTO? create(User_LessonDTO dto)
        {
            using var context = new DBCon();
            User? user = context.Users.FirstOrDefault(x => x.Id == dto.userId);
            Lesson? lesson = context.Lessons.FirstOrDefault(x => x.Id == dto.lessonId);
            if (user == null || lesson == null)
                return null;
            User_Lesson newLesson = new User_Lesson()
            {
                userId = dto.userId,
                user = user,
                lessonId = dto.lessonId,
                lesson = lesson,
                date = DateTime.ParseExact(dto.date, "dd.MM.yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture)
            };
            User_Lesson res = context.User_Lessons.Add(newLesson).Entity;
            context.SaveChanges();
            return res.getDto();
        }
        public User_LessonDTO? getById(int id)
        {
            using var context = new DBCon();
            User_Lesson? lesson = context.User_Lessons
                .Include(x => x.user)
                .Include(x => x.lesson)
                .FirstOrDefault(x => x.Id == id);
            if (lesson == null)
                return null;
            return lesson.getDto();
        }
        public List<User_LessonDTO> getAll(int page)
        {
            using var context = new DBCon();
            return context.User_Lessons
                .Include(x => x.user)
                .Include(x => x.lesson)
                .Skip(page * PAGE_SIZE).Take(PAGE_SIZE).Select(x => x.getDto()).ToList();
        }
        public List<User_LessonDTO> getBy(int id)
        {
            using var context = new DBCon();
            return context.User_Lessons
                .Include(x => x.user)
                .Include(x => x.lesson)
                .Where(x => x.userId == id).Select(x => x.getDto()).ToList();
        }
        public User_LessonDTO? delete(int id)
        {
            using var context = new DBCon();
            User_Lesson? lesson = context.User_Lessons.FirstOrDefault(x => x.Id == id);
            if (lesson == null)
                return null;
            context.User_Lessons.Remove(lesson);
            context.SaveChanges();
            return lesson.getDto();
        }
    }
}
