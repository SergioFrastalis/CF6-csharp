using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppStarter.Models.DTO;
using WebAppStarter.Models;


namespace WebAppStarter.Pages.Students
{
    public class ViewStudentsModel : PageModel
    {
        public List<StudentReadOnlyDTO> StudentsReadOnlyDTOs { get; set; } = [
            MapStudentToDTO(new Student { Id = 1, FirstName = "Avva", LastName = "Giannou" }),
            MapStudentToDTO(new Student { Id = 2, FirstName = "Costas", LastName = "Androutsos" }),
            MapStudentToDTO(new Student { Id = 3, FirstName = "Tasos", LastName = "Fragos" })
        ];

        public void OnGet()
        {
        }

        private static StudentReadOnlyDTO MapStudentToDTO(Student student)
        {
            return new StudentReadOnlyDTO
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName
            };
        }
    }
}
