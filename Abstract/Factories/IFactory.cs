using Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factories
{
    public interface IFactory               
    {
        IBed CreateBed();
        IChair CreateChair();
        ITable CreateTable();      

    }
}
