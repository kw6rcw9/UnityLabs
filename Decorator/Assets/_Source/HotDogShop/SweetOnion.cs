namespace HotDogShop
{
    public class SweetOnion : HotDogDecorator
    {
        
        public SweetOnion(AHotDog hotDog) : base(hotDog.GetName + " со сладким луком", hotDog)
        {
        }

        public override int GetCost()
        {
            return _hotDog.GetCost() + 30;
        }

        public override int GetWeight()
        {
            return _hotDog.GetWeight() + 10;
        }
    }
}
