using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
	public class GroomingScheduler : Scheduler
	{
		private static GroomingScheduler instance;

		public static GroomingScheduler Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new GroomingScheduler();
				}

				return instance;
			}
		}

		protected override string GetMessage()
		{
			return "Grooming the animals...";
		}

		protected override void RunJob(Keeper keeper, Animal animal)
		{
			var groomableAnimal = animal as IGroomable;

			if (groomableAnimal != null)
			{
				keeper.GroomAnimal(groomableAnimal);
			}
		}
	}
}