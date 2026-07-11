namespace DomainSpecificType;

public class NaturalFloat
{
    private readonly double _value;

    public NaturalFloat(double value)
    {
        if (value < 0.0) throw new ArgumentOutOfRangeException(nameof(value), "Invalid natural float");
        _value = value;
    }

    public static bool TryCreate(double value, out NaturalFloat result)
    {
        if (value < 0.0)
        {
            result = null!;
            return false;
        }

        result = new NaturalFloat(value);
        return true;
    }

    public static explicit operator double(NaturalFloat nf) => nf._value;

    public static NaturalFloat operator +(NaturalFloat a, NaturalFloat b)
    {
        return new NaturalFloat(a._value + b._value);
    }

    public static NaturalFloat operator -(NaturalFloat a, NaturalFloat b)
    {
        if (a._value < b._value) throw new ArgumentOutOfRangeException($"{a} - {b}", "Invalid natural float computation");
        return new NaturalFloat(a._value - b._value);
    }

    public static NaturalFloat operator *(NaturalFloat a, NaturalFloat b)
    {
        return new NaturalFloat(a._value * b._value);
    }

    public static NaturalFloat operator /(NaturalFloat a, NaturalFloat b)
    {
        if (b._value == 0.0) throw new DivideByZeroException($"Invalid divisor: {b}");
        return new NaturalFloat(a._value / b._value);
    }

    public static bool operator ==(NaturalFloat a, NaturalFloat b)
    {
        return Math.Abs(a._value - b._value) < 0.00001;
    }

    public static bool operator !=(NaturalFloat a, NaturalFloat b)
    {
        return !(a == b);
    }

    public static bool operator <(NaturalFloat a, NaturalFloat b)
    {
        return a._value < b._value;
    }

    public static bool operator >(NaturalFloat a, NaturalFloat b)
    {
        return a._value > b._value;
    }

    public static bool operator <=(NaturalFloat a, NaturalFloat b)
    {
        return a._value <= b._value;
    }

    public static bool operator >=(NaturalFloat a, NaturalFloat b)
    {
        return a._value >= b._value;
    }

    public override bool Equals(object? obj)
    {
        if (obj is NaturalFloat other) return this == other;
        return false;
    }

    public override int GetHashCode()
    {
        return Math.Round(_value, 5).GetHashCode();
    }

    public override string ToString()
    {
        return _value.ToString();
    }
}
