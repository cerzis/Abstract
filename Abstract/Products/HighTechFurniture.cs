using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Products
{
    public class HighTechBed: IBed

    {
        public void Create()
        {
            Console.WriteLine("Вы создали кровать в стиле хай тек");
        }
    }
    public class HighTechChair : IChair

    {
        public void Create()
        {
            Console.WriteLine("Вы создали стул в стиле хай тек");
        }
    }
    public class HighTechTable : ITable

    {
        public void Create()
        {
            Console.WriteLine("Вы создали стол в стиле хай тек");
        }
    }
}
