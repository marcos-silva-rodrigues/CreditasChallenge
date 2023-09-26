using System.ComponentModel.DataAnnotations;

namespace CreditasChallenge.Dto
{
    public class CustomerDto
    {

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(150, ErrorMessage = "Insira até 150 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [RegularExpression(@"^(\d){3}.(\d){3}.(\d){3}-(\d){2}$",
         ErrorMessage = "Formato inválido, insira o seguinte formato: 123.456.789-10")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [Range(18, 80, ErrorMessage = "Insira um ano entre 18 e 80")]
        public int Age { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(2, ErrorMessage = "Insira os 2 caracterers do estado")]
        public string Location { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [Range(0, 100000, ErrorMessage = "Insira um valor entre 0 e 100.000")]
        public double Income { get; set; }
    }
}
