namespace HotDogShop
{
    public abstract class AHotDog 
    {
   
        public AHotDog(string name)
        {
            GetName = name;
            
        }

        public string GetName{get; protected set; }
        public abstract int GetWeight();
   
        public abstract int GetCost();
    }
}
