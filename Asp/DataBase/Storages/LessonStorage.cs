using Asp.DataBase.Models;
using Asp.DTO;

namespace Asp.DataBase.Storages
{
    public class LessonStorage
    {
        readonly int PAGE_SIZE = 5;
        public LessonDTO create(LessonDTO dto)
        {
            using var context = new DBCon();

            Lesson newLesson = new Lesson()
            {
                title = dto.title,
                desc = dto.desc
            };
            Lesson res = context.Lessons.Add(newLesson).Entity;
            context.SaveChanges();
            return res.getDto();
        }
        public LessonDTO? getById(int id)
        {
            using var context = new DBCon();
            Lesson? lesson = context.Lessons.FirstOrDefault(x => x.Id == id);
            if (lesson == null)
                return null;
            return lesson.getDto();
        }
        public List<LessonDTO> getAll()
        {
            using var context = new DBCon();
            return context.Lessons.Select(x => x.getDto()).ToList();
        }
        public List<LessonDTO> getByPage(int page)
        {
            using var context = new DBCon();
            return context.Lessons.Skip(page * PAGE_SIZE).Take(PAGE_SIZE).Select(x => x.getDto()).ToList();
        }
        public LessonDTO? delete(int id)
        {
            using var context = new DBCon();
            Lesson? lesson = context.Lessons.FirstOrDefault(x => x.Id == id);
            if (lesson == null)
                return null;
            context.Lessons.Remove(lesson);
            context.SaveChanges();
            return lesson.getDto();
        }
        public LessonDTO? update(LessonDTO dto)
        {
            using var context = new DBCon();


            using var transaction = context.Database.BeginTransaction();
            try
            {
                Lesson? lesson = context.Lessons.FirstOrDefault(x => x.Id == dto.Id);

                if (lesson == null)
                    return null;

                lesson.title = dto.title;
                lesson.desc = dto.desc;

                context.SaveChanges();
                transaction.Commit();
                return lesson.getDto();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return null;
            }


        }
    }
}
