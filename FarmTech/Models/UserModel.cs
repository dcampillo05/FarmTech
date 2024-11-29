using FarmTech.Enums;
using System.ComponentModel.DataAnnotations;

namespace FarmTech.Models
{
    public class UserModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Nome do Usuario")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "O e-mail informado não é valido")]
        [Required(ErrorMessage = "Digite o E-mail do Usuario")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o login do Usuario")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o senha do Usuario")]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? dtUpdate { get; set; }

        public EnumProfile  Profile { get; set; }

        public bool ValidPassword(string senha)
        {
            return Password == senha;
        }

    }
}
