namespace M2HW3
{
    using System;

    internal class Chocolate : IComparable<Chocolate>
    {
        private readonly double _weight;

        public Chocolate(double weight)
        {
            _weight = weight;
        }

        public double Weight
        {
            get
            {
                return _weight;
            }
        }

#nullable enable
        public int CompareTo(Chocolate? candy)
        {
            if (candy is null)
            {
                throw new ArgumentException("Некорректное значение параметра");
            }

            return Weight.CompareTo(candy.Weight);
        }

        public virtual string Type() => "Type of candy";
    }
}
