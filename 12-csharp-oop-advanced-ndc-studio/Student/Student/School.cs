using System.Security.Cryptography.X509Certificates;

namespace StudentSpace
{
	public class School
	{
		public List<Student> StudentList { get; set; } = [];

		public void AddStudent(Student student)
		{
			bool alreadyExists = StudentList.Any(s => s.Name == student.Name);

			if (!alreadyExists)
			{
				StudentList.Add(student);
				Console.WriteLine($"The student called {student.Name} has been added to the list.");
			}
			else
			{
				Console.WriteLine($"The student called {student.Name} is already in the list.");
			}
		}


		public void ListStudents()
		{
			foreach (var studentOfStudent in StudentList)
			{
				Console.WriteLine($"\nName: {studentOfStudent.Name}\nAge: {studentOfStudent.Age}\nAverage grades:{studentOfStudent.GetAverageGrade()}");
			}
		}

		public Student? FindStudent(string name)
		{
			foreach (var studentOfStudent in StudentList)
			{
				if (studentOfStudent.Name == name)
				{
					return studentOfStudent;
				}
			}
			return null;
		}

		public class TopStudent
        {
            public string Name { get; set; }
            public double Average { get; set; }

			public TopStudent(string name, double average)
            {
                Name = name;
                Average = average;
			}
		}

		public List<TopStudent> newList { get; set; } = [];

		public void ListTopStudents(int topN)
		{
			foreach (var studentOfTheList in StudentList)
			{
				var topStudent = new TopStudent(studentOfTheList.Name, studentOfTheList.GetAverageGrade());
				newList.Add(topStudent);
			}

            newList = newList.OrderByDescending(s => s.Average).ToList();


            for (int i = 0; i < topN; i++)
			{
                Console.WriteLine($"{newList[i].Name} | {newList[i].Average}");
            }

		}
	}
}