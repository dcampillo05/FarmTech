using FarmTech.Models;
using FarmTech.Repositorio;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FarmTech.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserRepositorio _userRepositorio;
        public UserController(IUserRepositorio userRepositorio)
        {
            _userRepositorio = userRepositorio;
        }

        public IActionResult Index()
        {
            List<UserModel> users = _userRepositorio.SearchAll();
            return View(users);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserModel user)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    _userRepositorio.Adicionar(user);
                    TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                    foreach (var error in errors)
                    {
                        Console.WriteLine(error);
                    }
                }


                return View(user);
            }
            catch (System.Exception erro)
            {
                Console.WriteLine($"Erro: {erro.Message}");
                TempData["MensagemErro"] = $"Falha ao cadastrar o Usuário! Tente novamente. Detalhe do erro: {erro.Message}";
                return View(user);
            }

        }


        public IActionResult Update(int id)
        {
            UserModel user = _userRepositorio.ListForId(id);
            return View(user);
        }

        [HttpPost]
        public IActionResult Alter(UserNotPasswordModel userNotPassword)
        {
            try
            {

                UserModel user = null;

                if (ModelState.IsValid)
                {
                    user = new UserModel()
                    {
                        Id = userNotPassword.Id,
                        Name = userNotPassword.Name,
                        Email = userNotPassword.Email,
                        Login = userNotPassword.Login,
                        Profile = userNotPassword.Profile,
                    };

                    user = _userRepositorio.Atualizar(user);
                    TempData["MensagemSucesso"] = "Usuário atualizado com sucesso!";
                    return RedirectToAction("Index");
                }


                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Falha ao atualizar o Usuário! Tente novamente. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult DeleteConfirm(int id)
        {
            UserModel user = _userRepositorio.ListForId(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        public IActionResult Delete(int id)
        {
            try
            {
                bool apagado = _userRepositorio.Deleter(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Usuário deletado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = $"Falha ao deletar o Usuário! Tente novamente";
                }

                return RedirectToAction("Index");

            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Falha ao deletar o Usuário! Tente novamente. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
