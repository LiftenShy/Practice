
namespace Event_Delegate
{
    class Bike : IProduct
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public  double Length { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Cost { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}; Type: {Type}; Weight: {Weight}; Height {Height}; Length: {Length} Cost: {Cost}";
        }
    }
}
