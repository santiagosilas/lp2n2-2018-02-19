using System;

public class ProductManager
{
    public IList<Product> ListProducts()
    {
        ProductRepository repository = new ProductRepository();
        IList<Product> products = repository.GetAllProducts();
        return products;
    }
}
