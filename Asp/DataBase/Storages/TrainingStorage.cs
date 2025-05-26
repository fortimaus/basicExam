using Asp.DataBase.Models;
using Asp.DTO;
using Microsoft.EntityFrameworkCore;

namespace Asp.DataBase.Storages
{
    public class TrainingStorage
    {
        readonly int PAGE_SIZE = 5;
        public TrainingDTO create(TrainingDTO dto)
        {
            using var context = new DBCon();
            
            Training newTraining = new Training()
            {
                title = dto.title
            };
            Training res = context.Trainings.Add(newTraining).Entity;
            context.SaveChanges();
            return res.getDto();
        }
        public TrainingDTO? getById(int id)
        {
            using var context = new DBCon();
            Training? training = context.Trainings.FirstOrDefault(x => x.Id == id);
            if (training == null)
                return null;
            return training.getDto();
        }
        public List<TrainingDTO> getAll()
        {
            using var context = new DBCon();
            return context.Trainings.Select(x => x.getDto()).ToList();
        }
        public List<TrainingDTO> getByPage(int page)
        {
            using var context = new DBCon();
            return context.Trainings.Skip(page * PAGE_SIZE).Take(PAGE_SIZE).Select(x => x.getDto()).ToList();
        }
        public TrainingDTO? delete(int id)
        {
            using var context = new DBCon();
            Training? training = context.Trainings.FirstOrDefault(x => x.Id == id);
            if (training == null)
                return null;
            context.Trainings.Remove(training);
            context.SaveChanges();
            return training.getDto();
        }
        public List<TrainingDTO> getSortByTitle(int page)
        {
            using var context = new DBCon();
            return context.Trainings
                .OrderBy(x => x.title)
                .Skip(page * PAGE_SIZE).Take(PAGE_SIZE)
                .Select(x => x.getDto()).ToList();
        }
        public List<TrainingDTO> getSearchByTitle(string title)
        {
            using var context = new DBCon();
            return context.Trainings
                .Where(x => x.title.ToLower().Contains(title.ToLower()))
                .Select(x => x.getDto())
                .ToList();
        }
        public TrainingDTO? update(TrainingDTO dto)
        {
            using var context = new DBCon();


            using var transaction = context.Database.BeginTransaction();
            try
            {
                Training? training = context.Trainings.FirstOrDefault(x => x.Id == dto.Id);

                if (training == null)
                    return null;

                training.title = dto.title;

                context.SaveChanges();
                transaction.Commit();
                return training.getDto();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return null;
            }


        }
    }
}
