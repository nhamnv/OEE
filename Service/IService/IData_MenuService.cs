using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
	public interface IData_MenuService
	{
		ICollection<Data_Menu> GetList();
	}
}
