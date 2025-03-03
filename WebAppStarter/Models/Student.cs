namespace WebAppStarter.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public Student() { }

        public Student(int id, string? firstName, string? lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        
        public override string? ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
