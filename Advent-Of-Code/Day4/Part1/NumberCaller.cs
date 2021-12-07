namespace Advent_Of_Code.Day4.Part1
{
    public class NumberCaller
    {
        private readonly List<int> Numbers;
        public Number? Last;
        private int _numerator;

        public NumberCaller(List<int> numbers)
        {
            Numbers = numbers;
        }

        public delegate void NumberCalledEventHandler(object source, NumberEventArgs args);
        public event NumberCalledEventHandler NumberCalled;

        public void CallNumber()
        {
            Number number = new Number(Numbers[_numerator]);
            Last = number;
            _numerator++;
            NumberEventArgs numberEventArgs = new NumberEventArgs() { Number = number };
            OnNumberCalled(numberEventArgs);

        }
        protected virtual void OnNumberCalled(NumberEventArgs number)
        {
            if (NumberCalled != null)
            {
                NumberCalled(this, number);
            }
        }
    }
}
