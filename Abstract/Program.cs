using Abstract;
using Abstract.Factories;

class Program
{
    static void Main(string[] args)
    {
        IFactory factory = new ClassicFactory();
        Client client = new Client(factory);
        client.Print();
    }

}