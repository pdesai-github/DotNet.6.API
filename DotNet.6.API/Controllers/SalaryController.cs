using DotNet._6.API.Models;
using DotNet._6.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet._6.API.Controllers
{
    [Route("api/employee/{id}/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Salary>> GetSalaries(int id)
        {
            List<Employee> employees = new EmployeeRepo().GetEmployeesWithSalaries();
            Employee employee = employees.Find(e => e.Id == id);
            if (employee != null)
                return Ok(employee.Salaries);
            else
                return NotFound();

        }

        [HttpGet]
        [Route("{month}")]
        public ActionResult<Salary> GetSalary(int id, string month)
        {
            List<Employee> employees = new EmployeeRepo().GetEmployeesWithSalaries();
            Employee employee = employees.Find(e => e.Id == id);
            if (employee != null)
            {
                Salary salary = employee.Salaries.Find(s => s.Month == month);
                if (salary != null)
                    return Ok(salary);
                else
                    return NotFound();
            }
            else
                return NotFound();
        }
    }
}
