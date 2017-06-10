using System;

namespace CompanySystem
{
	[Serializable]
	public class Entity
	{
		public int Id { get; set; }

		public override bool Equals(object obj)
		{
			return obj is Entity && (obj as Entity).Id == Id;
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode();
		}
	}
}
