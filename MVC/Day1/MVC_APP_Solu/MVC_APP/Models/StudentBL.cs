namespace MVC_APP.Models
{
    public class StudentBL
    {
        List<Student> students;//class DB
        public StudentBL()
        {
            students = new List<Student>();//obj
            students.Add(new Student() { Id = 1, Name = "basmala",Title="E",ImageURL="2.jpg"});
            students.Add(new Student() { Id = 2, Name = "mona", Title = "o", ImageURL = "2.jpg" });
            students.Add(new Student() { Id = 3, Name = "mustafa", Title = "f", ImageURL = "2.jpg" });
            students.Add(new Student() { Id = 4, Name = "sara", Title = "x", ImageURL = "2.jpg" });
            students.Add(new Student() { Id = 5, Name = "ali", Title = "c", ImageURL = "2.jpg" });

        }
        public List<Student> GetStudents() {
            return students;
        }
        public Student GetID(int id) {
            return students.FirstOrDefault(s => s.Id == id);
        }
    }
}
