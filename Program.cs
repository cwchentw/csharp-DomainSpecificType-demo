namespace DomainSpecificType;

class Program
{
    static void Main(string[] args)
    {
        TryCatchDemo();
        TryCreateDemo();
    }

    static void TryCatchDemo()
    {
        try
        {
            var a = new NaturalFloat(3.6);
            var b = new NaturalFloat(2.4);
            Console.WriteLine(a - b);
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e);
            return;
        }
    }

    static void TryCreateDemo()
    {
        if (NaturalFloat.TryCreate(3.6, out var a)
            && NaturalFloat.TryCreate(2.4, out var b))
        {
            try
            {
                Console.WriteLine(a - b);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return;
            }
        }
        else
        {
            Console.Error.WriteLine("Invalid input");
            return;
        }
    }
}
