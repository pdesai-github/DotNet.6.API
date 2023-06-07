namespace DotNet._6.API.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public List<Salary> Salaries { get; set; }
    }
}
