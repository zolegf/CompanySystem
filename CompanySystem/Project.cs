using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem
{
    public enum ProjectState
    {
        New,
        InProgress,
        Finished,
        Delay
    }
    [Serializable]
    public class Project
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public ProjectState State { get; set; }

        public Manager Manager { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();

		public override string ToString()
		{
			return Title;
		}
	}
}
