namespace Advent_Of_Code.Day4.Part1
{
    public class Number
    {
        public int Value { get; init; }
        public bool Called { get; private set; }

        public Number(int number)
        {
            Value = number;
        }

        public bool IsNumber(Number number)
        {
            if (number.Value == Value)
            {
                Called = true;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override bool Equals(object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Number n = (Number)obj;
            return (n.Value == Value);
        }
    }
}
