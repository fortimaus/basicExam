using Asp.DataBase.Models;
using Asp.DTO;
using Microsoft.EntityFrameworkCore;

namespace Asp.DataBase.Storages
{
    public class UserStorage
    {
        readonly int PAGE_SIZE = 5;
        public UserDto? login(string login, string password)
        {
            using var context = new DBCon();
            User? user = context.Users
                .Include(x => x.training)
                .FirstOrDefault(x => x.login.Equals(login) && x.password.Equals(password));
            if (user == null)
                return null;
            return user.getDto();
        }
        public UserDto register(UserDto dto)
        {
            using var context = new DBCon();
            Training? training = context.Trainings.FirstOrDefault(x => x.Id == dto.trainingId);
            User? user = context.Users.FirstOrDefault(x => x.login.Equals(dto.login));
            if (user != null)
                return null;
            if (training == null)
                return null;
            User newUser = new User()
            {
                login = dto.login,
                password = dto.password,
                trainingId = dto.trainingId,
                role = Enums.UserRole.User,
                training = training
            };
            User res = context.Users.Add(newUser).Entity;
            context.SaveChanges();
            return res.getDto();
        }
        public UserDto getById(int id)
        {
            using var context = new DBCon();
            User? user = context.Users.Include(x => x.training).FirstOrDefault(x => x.Id == id);
            if (user == null)
                return null;
            return user.getDto();
        }
        public List<UserDto> getPage(int page)
        {
            using var context = new DBCon();
            return context.Users.Include(x => x.training).Skip(page*PAGE_SIZE).Take(PAGE_SIZE).Select(x=> x.getDto()).ToList();
        }
        public List<UserDto> getSortByLogin(int page)
        {
            using var context = new DBCon();
            return context.Users.Include(x => x.training).OrderBy(x => x.login).Skip(page * PAGE_SIZE).Take(PAGE_SIZE).Select(x => x.getDto()).ToList();
        }
        public List<UserDto> getSearchByLogin(string login)
        {
            using var context = new DBCon();
            return context.Users
                .Include(x => x.training)
                .Where(x => x.login.ToLower().Contains(login.ToLower())).Select(x => x.getDto())
                .ToList();
        }
        public UserDto delete(int id)
        {
            using var context = new DBCon();
            User? user = context.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
                return null;
            context.Users.Remove(user);
            context.SaveChanges();
            return user.getDto();
        }
        public UserDto update(UserDto dto)
        {
            using var context = new DBCon();

            
            using var transaction = context.Database.BeginTransaction();
            try
            {
                User? user = context.Users.FirstOrDefault(x => x.Id == dto.Id);
                Training? training = context.Trainings.FirstOrDefault(x => x.Id == dto.trainingId);

                if (training == null || user == null)
                    return null;
                
                user.login = dto.login;
                user.password = dto.password;
                user.trainingId = dto.trainingId;
                user.training = training;

                context.SaveChanges();
                transaction.Commit();
                return user.getDto();
            }
            catch(Exception ex)
            {
                transaction.Rollback();
                return null;
            }
            
            
        }
    }
}
