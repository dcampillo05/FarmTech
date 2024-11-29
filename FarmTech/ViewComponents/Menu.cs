using FarmTech.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FarmTech.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (HttpContext == null || HttpContext.Session == null)
            {
                // Retorne uma view vazia ou null, dependendo do que deseja exibir
                return Content("");
            }

            string userSession = HttpContext.Session.GetString("sessionUserLogged");

            if (string.IsNullOrEmpty(userSession))
            {
                // Retorne uma view padrão ou null
                return Content("");
            }

            UserModel user = JsonConvert.DeserializeObject<UserModel>(userSession);

            // Aqui você pode passar o objeto "user" para a view, se necessário
            return await Task.FromResult(View(user));
        }
    }
}