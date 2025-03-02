namespace WebApp6Starter.Services
{
    public class IStudentService
    {
        StudentReadOnlyDTO? InsertStudent(StudentInsertDTO studentInsertDTO);
        void UpdateStudent(StudentUpdateDTO studentUpdateDTO);
        void DeleteStudent(int id);

    }
}
