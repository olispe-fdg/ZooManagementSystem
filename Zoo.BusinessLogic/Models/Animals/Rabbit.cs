using System;

namespace Zoo.BusinessLogic.Models.Animals
{
	public class Rabbit : Animal, IGroomable
	{
		private GroomingBehaviour groomingBehaviour = new GroomingBehaviour();

		public Rabbit(DateTime dateOfBirth) : base(dateOfBirth)
		{
		}

		public override void Feed()
		{
			Console.WriteLine("<Munch, munch>");
			base.Feed();
		}

		public void Groom()
		{
			groomingBehaviour.Groom();
		}

		public override string ToString()
		{
			return $"{base.ToString()}; {groomingBehaviour.ToString()}";
		}
	}
}