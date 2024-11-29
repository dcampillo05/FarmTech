using FarmTech.Models;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace FarmTech.Helpers
{
	public class Session : ISession
	{
		private readonly IHttpContextAccessor _Httpcontext;

		public Session(IHttpContextAccessor httpContext)
		{
			_Httpcontext = httpContext;
		}

		public UserModel searchUserSession()
		{
			string userSession = _Httpcontext.HttpContext.Session.GetString("sessionUserLogged");

			if (string.IsNullOrEmpty(userSession)) return null;

			return JsonConvert.DeserializeObject<UserModel>(userSession);
		}

		public void createUserSession(UserModel user)
		{
			string value = JsonConvert.SerializeObject(user);
			_Httpcontext.HttpContext.Session.SetString("sessionUserLogged", value);
		}

		public void removeUserSession()
		{
			_Httpcontext.HttpContext.Session.Remove("sessionUserLogged");
		}


	}
}
