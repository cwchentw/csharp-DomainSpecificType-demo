namespace DomainSpecificType;

public class NaturalInt
{
    private readonly int _value;

    public NaturalInt(int value)
    {
        if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), "Invalid natural int");
        _value = value;
    }

    public static explicit operator int(NaturalInt ni) => ni._value;

    public static bool TryCreate(int value, out NaturalInt result)
    {
        if (value < 0)
        {
            result = null!;
            return false;
        }

        result = new NaturalInt(value);
        return true;
    }

    public static NaturalInt operator +(NaturalInt a, NaturalInt b)
    {
        return new NaturalInt(a._value + b._value);
    }

    public static NaturalInt operator -(NaturalInt a, NaturalInt b)
    {
        if (a._value < b._value) throw new ArgumentOutOfRangeException($"{a} - {b}", "Invalid natural int computation");
        return new NaturalInt(a._value - b._value);
    }

    public static NaturalInt operator *(NaturalInt a, NaturalInt b)
    {
        return new NaturalInt(a._value * b._value);
    }

    public static NaturalInt operator /(NaturalInt a, NaturalInt b)
    {
        if (b._value == 0.0) throw new DivideByZeroException($"Invalid divisor: {b}");
        return new NaturalInt(a._value / b._value);
    }

    public static bool operator ==(NaturalInt a, NaturalInt b)
    {
        return a._value == b._value;
    }

    public static bool operator !=(NaturalInt a, NaturalInt b)
    {
        return a._value != b._value;
    }

    public static bool operator <(NaturalInt a, NaturalInt b)
    {
        return a._value < b._value;
    }

    public static bool operator >(NaturalInt a, NaturalInt b)
    {
        return a._value > b._value;
    }

    public static bool operator <=(NaturalInt a, NaturalInt b)
    {
        return a._value <= b._value;
    }

    public static bool operator >=(NaturalInt a, NaturalInt b)
    {
        return a._value >= b._value;
    }

    public override bool Equals(object? obj)
    {
        if (obj is NaturalInt other) return this == other;
        return false;
    }

    public override int GetHashCode()
    {
        return _value.GetHashCode();
    }

    public override string ToString()
    {
        return _value.ToString();
    }
}
