using SmartEnum.Common.Enum;

namespace SmartEnum.Enum;

public sealed class Color(string name, int value) : SmartEnum<Color>(name, value)
{
    public static readonly Color Red = new Color("Red", 1);
    public static readonly Color Blue = new Color("Blue", 2);
}