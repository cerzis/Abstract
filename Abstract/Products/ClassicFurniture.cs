using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Products
{
    public class ClassicBed : IBed

    {
        public void Create()
        {
            Console.WriteLine("Вы создали кровать в стиле классика");
        }
    }
    public class ClassicChair : IChair

    {
        public void Create()
        {
            Console.WriteLine("Вы создали стул в стиле классика");
        }
    }
    public class ClassicTable : ITable

    {
        public void Create()
        {
            Console.WriteLine("Вы создали стол в стиле классика");
        }
    }
}
