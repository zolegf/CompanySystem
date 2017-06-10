using System;

namespace CompanySystem
{
	public enum Gender
	{
		Male,
		Female
	}

    [Serializable]
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
		public DateTime DateOfBirth { get; set; }
		public Gender Gender { get; set; }
		public string Name => $"{FirstName} {LastName}";
		public Department Department { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
