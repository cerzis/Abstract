using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Products
{
    public class GothicBed : IBed

    {
        public void Create()
        {
            Console.WriteLine("Вы создали кровать в стиле готика");
        }
    }
    public class GothicChair : IChair

    {
        public void Create()
        {
            Console.WriteLine("Вы создали стул в стиле готика");
        }
    }
    public class GothicTable : ITable

    {
        public void Create()
        {
            Console.WriteLine("Вы создали стол в стиле готика");
        }
    }
}
