namespace M2HW3
{
    internal class BubleChocolate : CandyWithNoFilling
    {
        public BubleChocolate(double weight)
            : base(weight)
        {
        }

        public override string Type() => "Конфета из пористого шоколада";
    }
}
