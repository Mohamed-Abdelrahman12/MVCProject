using System.Security.Cryptography.X509Certificates;

namespace MVCProject.Models
{
	public class StudentBL
	{
		List<Student> students;
		public StudentBL()
		{
			students = new List<Student>()
			{
				new Student
				{
					Id = 1,
					FirstName = "Ahmed",
					LastName = "Mohamed",
					ImageURL = "a.jpg",
					Address = "123 Cairo St, Cairo",
					Age = 20
				},
				new Student
				{
					Id = 2,
					FirstName = "Sara",
					LastName = "Ali",
					ImageURL = "b.jpg",
					Address = "45 Giza Rd, Giza",
					Age = 19
				},
				new Student
				{
					Id = 3,
					FirstName = "Omar",
					LastName = "Hassan",
					ImageURL = "c.jpg", // Nullable field
					Address = "78 Alex St, Alexandria",
					Age = 21
				},
				new Student
				{
					Id = 4,
					FirstName = "Laila",
					LastName = "Khaled",
					ImageURL = "d.jpg",
					Address = null, // Nullable field
					Age = 22
				},
				new Student
				{
					Id = 5,
					FirstName = "Youssef",
					LastName = "Sayed",
					ImageURL = "m.jpg",
					Address = "12 Mansoura Ave, Mansoura",
					Age = null // Nullable field
				},
				new Student
				{
					Id = 6,
					FirstName = "Ayman",
					LastName = "Ibrahim",
					ImageURL = "n.jpg",
					Address = "34 Suez Rd, Suez",
					Age = 18
				},
				new Student
				{
					Id = 7,
					FirstName = "Khaled",
					LastName = "Mostafa",
					ImageURL = "u.jpg", // Nullable field
					Address = "56 Luxor St, Luxor",
					Age = 23
				}
			};
		}
		public List<Student> GetAllStudents()
		{
			return students;
		}
		public Student GetStudentByID(int id)
		{
			return students.FirstOrDefault(Std => Std.Id == id);
        }
	}
}
