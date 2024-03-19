namespace HotDogShop
{
    public class Cucumber : HotDogDecorator
    {
   
        public Cucumber( AHotDog hotDog) : base(hotDog.GetName + " с маринованными огурцами", hotDog)
        {
        }

        public override int GetCost()
        {
            return _hotDog.GetCost() + 50;
        }

        public override int GetWeight()
        {
            return _hotDog.GetWeight() + 20;
        }
    }
}
