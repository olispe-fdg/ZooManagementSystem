using System;

namespace Zoo.BusinessLogic.Models.Animals
{
	public class MuckSweepingBehaviour
	{
		private DateTime lastHadMuckSweptOut;

		public void SweepMuck()
		{
			lastHadMuckSweptOut = DateTime.Now;
		}

		public override string ToString()
		{
			return $"Last had muck swept out {lastHadMuckSweptOut}";
		}
	}

	public interface ICanHaveMuckSweptOut
	{
		void SweepMuck();
	}
}
