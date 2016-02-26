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
		public CoffeeRepository()
		{

		}

		public void Add(Coffee entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Coffee> GetAll()
		{
			throw new NotImplementedException();
		}

		public Coffee GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(Coffee update, int id)
		{
			throw new NotImplementedException();
		}
	}
}
