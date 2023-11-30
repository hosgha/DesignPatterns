using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement.Model
{
    public abstract class Asset
    {
        public abstract void AcceptVisitor(IVisitor visitor);
    }
}
