namespace StudentExamScoreSystem
{
	public interface IStudent
	{
		string GetName();
		string GetSurname();
		int GetCourse();
		int GetId();
		ExamScore GetExamScores();
	}
}
