using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
	public class FeedingScheduler : Scheduler
	{
		private static FeedingScheduler instance;

		public static FeedingScheduler Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new FeedingScheduler();
				}

				return instance;
			}
		}

		protected override string GetMessage()
		{
			return "Feeding the animals...";
		}

		protected override void RunJob(Keeper keeper, Animal animal)
		{
			if (animal.IsHungry())
			{
				keeper.FeedAnimal(animal);
			}
		}
	}
}