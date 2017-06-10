using System;

namespace CompanySystem
{
	public enum Gender
	{
		Male,
		Female
	}

    [Serializable]
    public class User
    {
        public int Id { get; set; }
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

        public override bool Equals(object obj)
        {
            return obj is User && (obj as User).Id == Id;
        }

        public override int GetHashCode() // ==> 123456
        {
            return Id.GetHashCode();
        }
    }
}
