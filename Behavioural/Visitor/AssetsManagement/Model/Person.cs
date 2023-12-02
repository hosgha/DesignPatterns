using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement.Model
{
    public class Person
    {
        public List<Asset> Assets { get; set; }

        public Person(params Asset[] assets)
        {
            this.Assets = assets.ToList();
        }

        public void AcceptAssetVisitor(IVisitor visitor)
        {
            foreach (var asset in Assets)
            {
                asset.AcceptVisitor(visitor);
            }
        }
    }
}
