using System;
using System.Linq;

namespace CitrineScript
{
    public class CSValue
    {
        public object NativeValue { get; }
        public CSValueType Type { get; }
        public static CSValue Void => new CSValue(null, CSValueType.Void);

        public CSValue(object value)
        {
            switch (value)
            {
                case int _:
                case float _:
                case double _:
                    Type = CSValueType.Number;
                    NativeValue = (double)value;
                    break;
                case bool i:
                    Type = CSValueType.Number;
                    NativeValue = i ? 1 : 0;
                    break;
                case string _:
                    Type = CSValueType.String;
                    NativeValue = value;
                    break;
                case Array _:
                    Type = CSValueType.Array;
                    NativeValue = (value as Array).Cast<object>().ToArray();
                    break;
                default:
                    Type = CSValueType.Any;
                    NativeValue = value;
                    break;
            }
        }

        protected CSValue(object value, CSValueType type) : this(value)
        {
            Type = type;
        }

        public override string ToString() => NativeValue?.ToString();

        public static implicit operator CSValue(int value) => new CSValue(value);
        public static implicit operator CSValue(double value) => new CSValue(value);
        public static implicit operator CSValue(float value) => new CSValue(value);
        public static implicit operator CSValue(bool value) => new CSValue(value);
        public static implicit operator CSValue(string value) => new CSValue(value);
        public static implicit operator string(CSValue value) => value.NativeValue as string;
    }

    public enum CSValueType
    {
        Any,
        Number,
        String,
        Array,
        Void
    }
}