using FarmTech.Models;

namespace FarmTech.Repositorio
{
    public interface IUserRepositorio
    {
        UserModel searchForLogin(string login);

        UserModel ListForId(int id);
        List<UserModel> SearchAll();
        UserModel Adicionar(UserModel user);

        UserModel Atualizar(UserModel user);

        bool Deleter(int id);

    }
}
