using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Domain;

namespace CoffeeShop.Repository
{
	public class CoffeeRepository : ICoffeeRepository
	{
		IList<Coffee> Data;
		public CoffeeRepository()
		{
			Data = DataClass.LoadCoffees().ToList();
		}

		public void Add(Coffee entity)
		{
			Data.Add(entity);
		}

		public void Delete(int id)
		{
			var coffee = Data.SingleOrDefault(cup => cup.Id == id);

			if (coffee != null)
				Data.Remove(coffee);

		}

		public IEnumerable<Coffee> GetAll()
		{
			return Data;
		}

		public Coffee GetById(int id)
		{
			return Data.SingleOrDefault(cup => cup.Id == id);
		}

		public void Update(Coffee update, int id)
		{
			var cup = GetById(id);

			cup = update;
		}
	}
}
