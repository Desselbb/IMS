using IMSClassLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSClassLibrary.Interfaces
{
    internal interface IInterface
    {

        
        bool Add(Department Department);

        bool AddRange(List<Department> Departments);

        Department Get(int Id);

        List<Department> GetAll();

        bool Update(Department Department);

        bool DeleteById(int Id);
    }
}
