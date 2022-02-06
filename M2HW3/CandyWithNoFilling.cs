namespace M2HW3
{
    internal class CandyWithNoFilling : Chocolate
    {
        public CandyWithNoFilling(double weight)
            : base(weight)
        {
        }

        public override string Type() => "Конфета без начинки";
    }
}
