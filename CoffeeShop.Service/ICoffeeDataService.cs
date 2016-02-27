using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Domain;

namespace CoffeeShop.Service
{
	public interface ICoffeeDataService
	{
		Coffee GetCoffeeDetail(int id);

		IEnumerable<Coffee> GetAllCoffees();

		void UpdateCoffee(Coffee coffee);

		void DeleteCoffee(Coffee coffee);
	}
}
