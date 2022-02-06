namespace M2HW3
{
    internal class CandyWithFilling : Chocolate
    {
        public CandyWithFilling(double weight)
            : base(weight)
        {
        }

        public override string Type() => "Конфета с начинкой";
    }
}
