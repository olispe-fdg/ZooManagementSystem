using System;
using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
	public abstract class Scheduler
	{
		protected Scheduler()
		{
		}

		protected virtual string GetMessage()
		{
			throw new NotImplementedException();
		}

		protected virtual void RunJob(Keeper keeper, Animal animal)
		{
			throw new NotImplementedException();
		}

		public void AssignJobs(IEnumerable<Keeper> keepers, IEnumerable<Animal> animals)
		{
			Console.WriteLine(GetMessage());

			foreach (var keeper in keepers)
			{
				foreach (var animal in keeper.GetResponsibleAnimals())
				{
					RunJob(keeper, animal);
				}
			}
		}
	}
}