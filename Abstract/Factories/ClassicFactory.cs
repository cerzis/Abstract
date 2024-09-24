using Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factories
{
    public class ClassicFactory : IFactory
    {
        public IBed CreateBed()
        {
            return new ClassicBed();
        }
        public IChair CreateChair()
        {
            return new ClassicChair();
        }
        public ITable CreateTable()
        {
            return new ClassicTable();
        }
    }
}
