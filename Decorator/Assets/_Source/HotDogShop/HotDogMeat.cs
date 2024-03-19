namespace HotDogShop
{
    public class HotDogMeat : AHotDog
    {
        private HotDogSo _data;
    
        public HotDogMeat(HotDogSo data) : base("Хот-Дог мясной")
        {
            _data = data;
        }

        public override int GetCost()
        {
            return 330;
        }

        public override int GetWeight()
        {
            return _data.Weight;
        }
    }
}
