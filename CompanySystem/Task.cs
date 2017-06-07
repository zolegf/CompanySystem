using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem
{
    public enum TaskState
    {
        To_Do,
        In_Progress,
        Done
    }
    [Serializable]
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TaskState TaskState { get; set; }
        public int TaskHours { get; set; }
        public string Description { get; set; }
        // navigational properties
        public Employee Employee { get; set; }
        public Project Project { get; set; }
    }
}
