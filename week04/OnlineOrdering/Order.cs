//Order.cs:
using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        total += _customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing List:\n";
        foreach (Product product in _products)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping to:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }//I did change this part by get's



}


