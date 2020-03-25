using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task03.DAL;
using Task03.Models;

namespace Task03.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IDbService _dbService;
        public StudentController(IDbService dbservice)
        {
           this. _dbService = dbservice;
        }
        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            switch (id)
            {
                case 1:
                    return Ok("Kowalski");
                    case 2:
                    return Ok("Malewski");
                default:
                    return NotFound("There is no student with given id");
            }
        }
        private Dictionary<int, Student> Students = new Dictionary<int, Student>();

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IdStudent = new Random().Next(1, 1000);
            Students.TryAdd(student.IdStudent, student);
            return Ok(student);
        }
        [HttpPut("{id}")]
        public IActionResult PutStudent(int id)
        {
            return Ok("Update Complete");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            Students.Remove(id);
            return Ok("Delete Completed");
        }
    }
}