
using System;

namespace Event_Delegate
{
    public class Client
    {
        public string Name { get; set; }

        private readonly string _id;

        public Client(string id, Publisher pub)
        {
            _id = id;
            pub.AddProduct += HandleCustomEvent;
        }

        void HandleCustomEvent(object sender, AddNewProductEventArgs e)
        {
            Console.WriteLine($"Id: {_id} information about new Product \n {e.Message}");
        }
    }
}
