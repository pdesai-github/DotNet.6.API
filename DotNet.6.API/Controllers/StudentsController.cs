using DataStore.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet._6.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentsController : ControllerBase
    {
        private readonly StudentsRepo studentsRepo;

        public StudentsController()
        {
            studentsRepo = new StudentsRepo();
        }

        [HttpGet]
        public ActionResult<List<DataStore.Models.Student>> Get()
        {
            return studentsRepo.GetAllStudents();
        }
    }
}
