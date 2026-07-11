namespace DomainSpecificType;

class Program
{
    static void Main(string[] args)
    {
        NaturalIntTryCatchDemo();
        NaturalIntTryCreateDemo();
        NaturalFloatTryCatchDemo();
        NaturalFloatTryCreateDemo();
    }

    static void NaturalIntTryCatchDemo()
    {
        try
        {
            var a = new NaturalInt(4);
            var b = new NaturalInt(3);
            Console.WriteLine(a - b);
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e);
            return;
        }
    }

    static void NaturalIntTryCreateDemo()
    {
        if (NaturalInt.TryCreate(4, out var a)
            && NaturalInt.TryCreate(3, out var b))
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

    static void NaturalFloatTryCatchDemo()
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

    static void NaturalFloatTryCreateDemo()
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
