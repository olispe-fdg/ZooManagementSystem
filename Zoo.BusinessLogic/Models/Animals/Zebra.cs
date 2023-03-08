using System;

namespace Zoo.BusinessLogic.Models.Animals
{
	public class Zebra : Animal, IGroomable
	{
		private GroomingBehaviour groomingBehaviour = new GroomingBehaviour();

		public Zebra(DateTime dateOfBirth) : base(dateOfBirth)
		{
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