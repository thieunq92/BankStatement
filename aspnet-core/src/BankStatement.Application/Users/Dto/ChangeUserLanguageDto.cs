using System.ComponentModel.DataAnnotations;

namespace BankStatement.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}