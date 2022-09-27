using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4_EF.Logic
{
    interface IAbmlLogic<T>
    {
        List<T> GetAll();

        bool Add(T newT);

        bool Delete(int id);

        bool Update(T newT);
    }
}
