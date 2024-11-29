using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace FarmTech.Models
{
    public class FornecedorModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Nome do Fornecedor")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "O e-mail informado não é valido")]
        [Required(ErrorMessage = "Digite o E-mail do Fornecedor")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "O número não é válido")]
        [Required(ErrorMessage = "Digite o Numero do Fornecedor")]
        public string Numero { get; set; }

        
        [Required(ErrorMessage = "Digite o CNPJ do Fornecedor")]
        public string Cnpj { get; set; }


    }
}
