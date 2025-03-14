using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppStarter.Models.DTO;

namespace WebAppStarter.Pages.Students
{
    public class IndexModel : PageModel
    {
        [BindProperty] //MVVM
        public InsertStudentDTO? InsertStudentDTO { get; set; } = new InsertStudentDTO();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                // Return the page with validation error
                return Page();
            }

            // Simulate saving the data (e.g., to a database)
            TempData["Message"] = $"Student{InsertStudentDTO?.Firstname} {InsertStudentDTO?.Lastname}" + $"added succesfully!";
            return RedirectToPage("/Students/Success"); // Redirect to a success page or reload
        }
    }
}
 