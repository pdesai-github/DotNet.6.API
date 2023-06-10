using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore.Repositories
{
    public class StudentsRepo
    {
        private readonly DataStoreContext _context;

        public StudentsRepo()
        {
            _context = new DataStoreContext();
            _context.Database.EnsureCreated();
            AddTestData();
        }

        public List<Models.Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Models.Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }

        public void AddStudent(Models.Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void UpdateStudent(Models.Student student)
        {
            var studentToUpdate = _context.Students.FirstOrDefault(s => s.Id == student.Id);
            studentToUpdate.Name = student.Name;
            studentToUpdate.Marks = student.Marks;
            _context.SaveChanges();
        }
        public void DeleteStudent(int id)
        {
            var studentToDelete = _context.Students.FirstOrDefault(s => s.Id == id);
            _context.Students.Remove(studentToDelete);
            _context.SaveChanges();
        }

        private void AddTestData()
        {
            if (GetAllStudents().Count == 0)
            {

                var student1 = new Models.Student( "John", new List<Models.Marks>() { new Models.Marks("Maths", 90), new Models.Marks("Science", 80) });
                var student2 = new Models.Student("Jane", new List<Models.Marks>() { new Models.Marks("Maths", 80), new Models.Marks("Science", 90) });
                var student3 = new Models.Student( "Jack", new List<Models.Marks>() { new Models.Marks("Maths", 70), new Models.Marks("Science", 70) });
                var student4 = new Models.Student( "Jill", new List<Models.Marks>() { new Models.Marks("Maths", 60), new Models.Marks("Science", 60) });
                var student5 = new Models.Student( "Joe", new List<Models.Marks>() { new Models.Marks("Maths", 50), new Models.Marks("Science", 50) });
                var student6 = new Models.Student( "Jenny", new List<Models.Marks>() { new Models.Marks("Maths", 40), new Models.Marks("Science", 40) });
                var student7 = new Models.Student( "James", new List<Models.Marks>() { new Models.Marks("Maths", 30), new Models.Marks("Science", 30) });
                var student8 = new Models.Student("Jade", new List<Models.Marks>() { new Models.Marks("Maths", 20), new Models.Marks("Science", 20) });
                var student9 = new Models.Student("Jasper", new List<Models.Marks>() { new Models.Marks("Maths", 10), new Models.Marks("Science", 10) });
                var student10 = new Models.Student( "Jasmine", new List<Models.Marks>() { new Models.Marks("Maths", 0), new Models.Marks("Science", 0) });
                _context.Students.Add(student1);
                _context.Students.Add(student2);
                _context.Students.Add(student3);
                _context.Students.Add(student4);
                _context.Students.Add(student5);
                _context.Students.Add(student6);
                _context.Students.Add(student7);
                _context.Students.Add(student8);
                _context.Students.Add(student9);
                _context.Students.Add(student10);
                _context.SaveChanges();
            }
        }
    }
}
