using System.Drawing;

namespace Event_Delegate
{
    public class Cup : IProduct
    {
        public Color Color { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Cost { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}; Type: {Type}; Color: {Color.Name}; Cost: {Cost}";
        }
    }
}
