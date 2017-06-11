using System;
using System.Collections.Generic;

namespace CompanySystem
{
	public enum ProjectState
	{
		New,
		InProgress,
		Finished,
		Delay,
		Canceled
	}

	[Serializable]
	public class Project : Entity
	{
		private ProjectState _state;

		public string Title { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public string Description { get; set; }
		public ProjectState State
		{
			get
			{
				return _state;
			}

			set
			{
				_state = value;
				if (value == ProjectState.Canceled)
				{
					foreach (var item in Tasks)
					{
						item.TaskState = TaskState.Cancelled;
					}
				}
			}
		}

		public decimal Cost { get; set; }
		public Manager Manager { get; set; }
		public List<Task> Tasks { get; set; } = new List<Task>();

		public override string ToString()
		{
			return Title;
		}
	}
}
