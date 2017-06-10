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
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public ProjectState State { get; set; }
		public decimal Cost { get; set; }
		public Manager Manager { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();

		public override string ToString()
		{
			return Title;
		}
	}
}
