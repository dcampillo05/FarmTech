using FarmTech.Data;
using FarmTech.Models;

namespace FarmTech.Repositorio
{
    public class UserRepositorio : IUserRepositorio
    {

        private readonly AppDbContext _context;

        public UserModel searchForLogin(string login)
        {
            return _context.User.FirstOrDefault(x => x.Login == login);
        }
        public UserRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public UserModel Adicionar(UserModel user)
        {
            user.CreatedAt = DateTime.Now;    
            _context.User.Add(user);
            _context.SaveChanges();
            return user;
        }

        public List<UserModel> SearchAll()
        {
            return _context.User.ToList();
        }

        public UserModel ListForId(int id)
        {
            return _context.User.FirstOrDefault(x => x.Id == id);
        }

        public UserModel Atualizar(UserModel user)
        {
            UserModel userDb = ListForId(user.Id);

            if (userDb == null)
            {
                throw new Exception("Houve um erro na atualização");
            }

            userDb.Name = user.Name;
            userDb.Login = user.Login;
            userDb.Email = user.Email;  
            userDb.Profile = user.Profile;
            userDb.dtUpdate = DateTime.Now;

            _context.User.Update(userDb);
            _context.SaveChanges();
            return userDb;

        }

        public bool Deleter(int id)
        {

            UserModel userDb = ListForId(id);

            if (userDb == null)
            {
                throw new Exception("Houve um erro na deleçao do Fornecedor");
            }

            _context.User.Remove(userDb);
            _context.SaveChanges();

            return true;

        }

    }
}
