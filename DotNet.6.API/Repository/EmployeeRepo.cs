using DotNet._6.API.Models;

namespace DotNet._6.API.Repository
{
    public class EmployeeRepo
    {
        public List<Employee> GetEmployeesWithSalaries()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John",
                    Salaries = new List<Salary>
                    {
                        new Salary
                        {
                            Month = "Jan",
                            Amount = 1000
                        },
                        new Salary
                        {
                            Month = "Feb",
                            Amount = 2000
                        },
                        new Salary
                        {
                            Month = "Mar",
                            Amount = 3000
                        }
                    }
                },
                new Employee
                {
                    Id = 2,
                    Name = "Jane",
                    Salaries = new List<Salary>
                    {
                        new Salary
                        {
                            Month = "Jan",
                            Amount = 1000
                        },
                        new Salary
                        {
                            Month = "Feb",
                            Amount = 2000
                        },
                        new Salary
                        {
                            Month = "Mar",
                            Amount = 3000
                        }
                    }
                },
                new Employee
                {
                    Id = 3,
                    Name = "Jack",
                    Salaries = new List<Salary>
                    {
                        new Salary
                        {
                            Month = "Jan",
                            Amount = 1000
                        },
                        new Salary
                        {
                            Month = "Feb",
                            Amount = 2000
                        },
                        new Salary
                        {
                            Month = "Mar",
                            Amount = 3000
                        }
                    }
                }
            };
            return employees;

            
        }

    }
}
