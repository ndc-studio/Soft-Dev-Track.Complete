namespace StudentSpace
{
	public class Student
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public List<Grade> Grades { get; set; } = [];


        public Student(string name, int age)
		{
			Name = name;
			Age = age;
		}

        public void AddGrade(string subject, int score)
        {
            Grade newGrade = new() { Subject = subject, Score = score };
            if (Grades.Count > 0)
            {
                foreach (Grade grade in Grades)
                {
                    if (grade.Subject == subject)
                    {
                        grade.Score += score;
                        return;
                    }
                }
            }
            Grades.Add(newGrade);
        }

        public double GetAverageGrade()
		{
			double totalScore = 0;
			foreach (var grades in Grades)
			{
				totalScore += grades.Score;
			}
			double result = totalScore / (Grades.Count);
			return result;
		}

		public void ListGrades()
		{
			Console.WriteLine("List of student's grades :");
			foreach (var grades in Grades)
			{
				string msg = $"- Subject: {grades.Subject} || Score: {grades.Score}";
				Console.WriteLine(msg);
			}
		}

	}
}