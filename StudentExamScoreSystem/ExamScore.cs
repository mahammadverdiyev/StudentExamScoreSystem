using System;

namespace StudentExamScoreSystem
{
	public class ExamScore
	{
		private int sdf1;
		private int sdf2;
		private int sdf3;
		private int final;
		public int Sdf1 { get => sdf1; set => sdf1 = value; }
		public int Sdf2 { get => sdf2; set => sdf2 = value; }
		public int Sdf3 { get => sdf3; set => sdf3 = value; }
		public int Final { get => final; set => final = value; }

		public ExamScore(int sdf1, int sdf2, int sdf3, int final)
		{
			this.sdf1 = sdf1;
			this.sdf2 = sdf2;
			this.sdf3 = sdf3;
			this.final = final;
		}

		public int CalculateAverage()
		{
			return (int)Math.Floor((sdf1 + sdf2 + sdf3 + 100 + 100) * 0.1 + final * 0.5);
		}
	}

}
