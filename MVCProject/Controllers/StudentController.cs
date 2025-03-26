using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;

namespace MVCProject.Controllers
{
	public class StudentController : Controller
	{
		public IActionResult GetAll()
		{
			StudentBL Students = new StudentBL();
			List<Student> studentList = Students.GetAllStudents();
			return View("GetAll", studentList);
		}
		public IActionResult GetStudent(int id)
		{
			StudentBL studentBL = new StudentBL();
			Student student = studentBL.GetStudentByID(id);
			return View("GetStudent",student);
		}
	}
}
