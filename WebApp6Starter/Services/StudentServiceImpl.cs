using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Diagnostics;

namespace WebApp6Starter.Services
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class StudentServiceImpl : IStudentService
    {

        private readonly IStudentDAO _studentDAO;
        private readonly IActionResultTypeMapper _mapper;
        private readonly ILogger<StudentServiceImpl> _logger;
        public StudentServiceImpl()
        {
        }



        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }


    }
}
