namespace HotDogShop
{
    public abstract class HotDogDecorator : AHotDog
    {
        protected AHotDog _hotDog;
        public  HotDogDecorator(string name, AHotDog hotDog) : base(name)
        {
            _hotDog = hotDog;
        }


        public override int GetCost()
        {
            return _hotDog.GetCost();
        }

        public override int GetWeight()
        {
            return _hotDog.GetWeight();
        }
    }
}
