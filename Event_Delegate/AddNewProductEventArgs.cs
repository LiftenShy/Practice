
using System;

namespace Event_Delegate
{
    public class AddNewProductEventArgs : EventArgs
    {
        public string Message { get; set; }

        public AddNewProductEventArgs(IProduct product)
        {
            Message = product.ToString();
        }
    }
}
