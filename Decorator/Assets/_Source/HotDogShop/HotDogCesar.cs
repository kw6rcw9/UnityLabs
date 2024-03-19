namespace HotDogShop
{
    public class HotDogCesar : AHotDog
    {
        private HotDogSo _data;

        public HotDogCesar(HotDogSo data) : base("Хот-Дог Цезарь")
        {
            _data = data;
        }

        public override int GetCost()
        {
            return 290;
        }

        public override int GetWeight()
        {
            return _data.Weight;
        }
    }
}
