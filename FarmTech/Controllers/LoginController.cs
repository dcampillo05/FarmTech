using FarmTech.Helpers;
using FarmTech.Models;
using FarmTech.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FarmTech.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserRepositorio _userRepositorio;
		private readonly FarmTech.Helpers.ISession _session;

        public LoginController(IUserRepositorio userRepositorio, FarmTech.Helpers.ISession session) { 
            _userRepositorio = userRepositorio;
			_session = session;
        }

        public IActionResult Index()
        {

			if(_session.searchUserSession() != null) return RedirectToAction("Index", "Home");

            return View();
        }

		public IActionResult Exit() { 
			_session.removeUserSession();

			return RedirectToAction("Index", "Login");
		}


        [HttpPost]
		public IActionResult Open(LoginModel loginModel)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
					{
						Debug.WriteLine($"Erro: {error.ErrorMessage}");
					}

					TempData["MensagemErro"] = "Preencha todos os campos corretamente.";
					return View("Index");
				}

				Debug.WriteLine($"Tentando fazer login com o login: {loginModel.Login}");

				UserModel user = _userRepositorio.searchForLogin(loginModel.Login);

				if (user == null)
				{
					TempData["MensagemErro"] = "Login não encontrado. Por favor, tente novamente.";
					Debug.WriteLine("Usuário não encontrado.");
					return View("Index");
				}

				Debug.WriteLine($"Senha armazenada: {user.Password}");

				if (user.ValidPassword(loginModel.Password))
				{
					_session.createUserSession(user);
					Debug.WriteLine("Login bem-sucedido!");
					return RedirectToAction("Index", "Home");
				}
				else
				{
					Debug.WriteLine("Senha incorreta.");
					TempData["MensagemErro"] = "Senha incorreta! Por favor, tente novamente.";
				}
			}
			catch (Exception error)
			{
				Debug.WriteLine($"Erro ao verificar login: {error.Message}");
				TempData["MensagemErro"] = $"Houve um problema com a verificação do login. Por favor, tente novamente! {error.Message}";
				return RedirectToAction("Index");
			}
			return View("Index");
		}
	}
}
