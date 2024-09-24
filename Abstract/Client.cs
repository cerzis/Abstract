using Abstract.Factories;
using Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Client
    {
        public IBed _bed;
        public IChair _chair;
        public ITable _table;

        public Client(IFactory factory)
        {
            _bed = factory.CreateBed();
            _chair = factory.CreateChair(); 
            _table = factory.CreateTable();
        }
        public void Print()
        {
            _bed.Create();
            _chair.Create();
            _table.Create();
        }
    }
}
