using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement.Model
{
    public interface IVisitor
    {
        void Visit(BankAccount bankAccount);
        void Visit(Car car);
        void Visit(RealEstate estate);
    }
}
