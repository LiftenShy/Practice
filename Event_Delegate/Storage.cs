using System;
using System.Collections.Generic;
using System.Linq;

namespace Event_Delegate
{
    public class Storage
    {
        public List<IProduct> Products { get; set; }

        public Func<string, int> SeacrhByType => CountTypeProduct;

        public Storage()
        {
            Products = new List<IProduct>();
        }

        private int CountTypeProduct(string type)
        {
            return Products.Count(x => x.Type.Equals(type, StringComparison.OrdinalIgnoreCase));
        }
    }
}
