using Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factories
{
    public class HighTechFactory : IFactory
    {
        public IBed CreateBed()
        {
            return new HighTechBed();
        }
        public IChair CreateChair()
        {
            return new HighTechChair();
        }
        public ITable CreateTable()
        {
            return new HighTechTable();
        }
    }
}
