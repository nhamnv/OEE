using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IData_MenuRepository : IGenericRepository<Data_Menu>
    {
        ICollection<Data_Menu> GetList();
    }
}
