using System;

namespace CompanySystem
{
    [Serializable]
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Department Department { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
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
