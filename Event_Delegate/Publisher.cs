
using System;
using System.Globalization;
using static System.String;

namespace Event_Delegate
{
    public class Publisher
    {
        public event EventHandler<AddNewProductEventArgs> AddProduct;

        public void AddNewProduct(IProduct product)
        {
            OnAddProduct(new AddNewProductEventArgs(product));
        }

        protected virtual void OnAddProduct(AddNewProductEventArgs e)
        {
            AddProduct?.Invoke(this, e);
        }
    }
}
