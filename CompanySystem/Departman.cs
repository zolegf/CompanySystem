using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem
{
    [Serializable]
    public class Department
    {
        public int Id { get; set; }
        public List<User> Employees { get; set; } = new List<User>();
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
