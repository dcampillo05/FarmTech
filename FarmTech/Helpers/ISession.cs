using FarmTech.Models;

namespace FarmTech.Helpers
{
	public interface ISession
	{
		void createUserSession(UserModel user);
		void removeUserSession();
		UserModel searchUserSession();

	}
}
