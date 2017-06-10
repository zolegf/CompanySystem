using System;
using System.Collections.Generic;

namespace CompanySystem
{
    [Serializable]
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<User> Employees { get; set; } = new List<User>();

        public override string ToString()
        {
            return Name;
        }
    }
}
