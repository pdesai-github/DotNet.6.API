using DotNet._6.API.Models;
using DotNet._6.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet._6.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Employee>> GetEmployees()
        {
            List<Employee> employees = new EmployeeRepo().GetEmployeesWithSalaries();

            if (employees.Count > 0)
                return Ok(employees);
            else
                return NotFound();

        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            List<Employee> employees = new EmployeeRepo().GetEmployeesWithSalaries();
            Employee employee = employees.Find(e => e.Id == id);
            if (employee != null)
                return Ok(employee);
            else
                return NotFound();
        }
    }
}
