using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Repository
{
	public interface IDataRepository<T>
	{
		T GetById(int id);

		IEnumerable<T> GetAll();

		void Update(T update, int id);

		void Delete(int id);

		void Add(T entity);
	}
}
