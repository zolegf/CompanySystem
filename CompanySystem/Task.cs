using System;

namespace CompanySystem
{
	public enum TaskState
	{
		To_Do,
		In_Progress,
		Done,
		Cancelled
	}

	[Serializable]
	public class Task : Entity
	{
		public string Title { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public TaskState TaskState { get; set; }
		public int TaskHours { get; set; }
		public int CompletedHours { get; set; }
		public int RemainingTasks { get; set; }
		public string Description { get; set; }
		public string Comment { get; set; }

		// navigational properties
		public Employee Employee { get; set; }
		public Project Project { get; set; }
	}
}
