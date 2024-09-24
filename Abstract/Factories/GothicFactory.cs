using Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factories
{
    public class GothicFactory : IFactory
    {
        public IBed CreateBed()
        {
            return new GothicBed();
        }
        public IChair CreateChair()
        {
            return new GothicChair();
        }
        public ITable CreateTable()
        {
            return new GothicTable();
        }
    }
}
