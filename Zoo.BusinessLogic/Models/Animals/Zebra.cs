using System;

namespace Zoo.BusinessLogic.Models.Animals
{
	public class Zebra : Animal, IGroomable, ICanHaveMuckSweptOut
	{
		private GroomingBehaviour groomingBehaviour = new GroomingBehaviour();
		private MuckSweepingBehaviour muckSweepingBehaviour = new MuckSweepingBehaviour();

		public Zebra(DateTime dateOfBirth) : base(dateOfBirth)
		{
		}

		public void Groom()
		{
			groomingBehaviour.Groom();
		}

		public void SweepMuck()
		{
			muckSweepingBehaviour.SweepMuck();
		}

		public override string ToString()
		{
			return $"{base.ToString()}; {groomingBehaviour.ToString()}; {muckSweepingBehaviour.ToString()}";
		}
	}
}