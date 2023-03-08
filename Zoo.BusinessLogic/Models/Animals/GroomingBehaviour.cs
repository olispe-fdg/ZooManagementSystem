using System;

namespace Zoo.BusinessLogic.Models.Animals
{
	public class GroomingBehaviour
	{
		private DateTime lastGroomed;

		public void Groom()
		{
			lastGroomed = DateTime.Now;
		}

		public override string ToString()
		{
			return $"Last Groomed {lastGroomed}";
		}
	}

	public interface IGroomable
	{
		void Groom();
	}
}
