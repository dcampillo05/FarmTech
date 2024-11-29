using FarmTech.Enums;
using System.ComponentModel.DataAnnotations;

namespace FarmTech.Models
{
    public class UserNotPasswordModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Nome do Usuario")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "O e-mail informado não é valido")]
        [Required(ErrorMessage = "Digite o E-mail do Usuario")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o login do Usuario")]
        public string Login { get; set; }

        public EnumProfile Profile { get; set; }

    }
}
