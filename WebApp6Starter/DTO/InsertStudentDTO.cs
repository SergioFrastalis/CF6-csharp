using System.ComponentModel.DataAnnotations;

namespace WebApp6Starter.DTO
{
    public class InsertStudentDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public string Lastname { get; set; }
    }
}
