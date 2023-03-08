using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
	public class MuckSweepingScheduler : Scheduler
	{
		private static MuckSweepingScheduler instance;

		public static MuckSweepingScheduler Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new MuckSweepingScheduler();
				}

				return instance;
			}
		}

		protected override string GetMessage()
		{
			return "Sweeping the animals' enclosures...";
		}

		protected override void RunJob(Keeper keeper, Animal animal)
		{
			var castAnimal = animal as ICanHaveMuckSweptOut;

			if (castAnimal != null)
			{
				keeper.SweepMuckForAnimal(castAnimal);
			}
		}
	}
}
