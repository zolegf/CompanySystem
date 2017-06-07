using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem
{
    [Serializable]
    public class Manager : User
    {
        public List<Project> Projects { get; set; } = new List<Project>();
        public List<Task> Tasks { get; set; } = new List<Task>();


       


    }
}
