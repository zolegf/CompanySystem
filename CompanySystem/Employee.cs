using System;
using System.Collections.Generic;

namespace CompanySystem
{
	[Serializable]
    public class Employee : User
    {
		public List<Project> Projects { get; set; } = new List<Project>();
	}
}
