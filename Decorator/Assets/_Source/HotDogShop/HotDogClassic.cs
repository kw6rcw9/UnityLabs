namespace HotDogShop
{
    public class HotDogClassic : AHotDog
    {

        private HotDogSo _data; 
        public HotDogClassic(HotDogSo data) : base("Хот-Дог Классический")
        {
            _data = data;
        }

        public override int GetCost()
        {
            return 210;
        }

        public override int GetWeight()
        {
            return _data.Weight;
        }
    }
}
