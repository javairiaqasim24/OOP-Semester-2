using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Product
    {
        public string Name;
        public string Category;
        public int Price;
        public int Quantity;
        public int StockQuantity;
        public float tax;

        private static List <Product> productList = new List<Product> ();

        public Product(string name , string category , int price , int quantity , int sQuantity)
        {
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
            StockQuantity = sQuantity;
            tax = CalculateTax();
            
        }

        public float CalculateTax()
        {
            if (Category == "Groceries"|| Category == "groceries")
            {
                return (Price * 0.1f) * Quantity;
            }

            else if(Category == "Fruits" ||  Category == "fruits")
            {
                return (Price * 0.05f) * Quantity;
            }
            else
            {
                return 0f;
            }

        }

        public void AddProduct()
        {
            bool ProductExist = false;

            if (!ProductExist)
            {
                productList.Add(this);
            }


            foreach (Product p in productList)
            {
                if(p.Name == Name)
                {
                    p.Quantity = p.Quantity + Quantity;
                    p.tax = p.CalculateTax();
                    ProductExist = true;
                    break;
                }
            }
            
        }

        public static void ViewProducts()
        {
            foreach (Product product in productList)
            {
                Console.WriteLine($"Name: {product.Name}   Category: {product.Category}   Price: {product.Price}   Quantity: {product.Quantity}   ");
            }
        }

        public static void HighPriceProduct()
        {
            int largest = 0;
            int x = -1;
            for(int i = 0; i < productList.Count; i++)
            {
                if (productList[i].Price > largest)
                {
                    largest = productList[i].Price;
                    x = i;
                }

            }
            Console.WriteLine($"Name: {productList[x].Name}   Category: {productList[x].Category}   Price:  {productList[x].Price}  Quantity: {productList[x].Quantity}  ");
        }
        public static void ProductTax()
        {
            foreach (Product product in productList)
            {
                Console.WriteLine($"Name: {product.Name}   Category: {product.Category}   Price: {product.Price}   Quantity: {product.Quantity}   Tax: {product.tax}");
            }
        }
        public static void Ordered()
        {
            bool found = false;
            for(int i = 0; i < productList.Count; i++)
            {
                if ( productList[i].Quantity < productList[i].StockQuantity)
                {
                    Console.WriteLine($"Name: {productList[i].Name}   Quantity:  {productList[i].Quantity}");
                    found = true;
                }
            }
             
            if(!found)
            {
                Console.WriteLine("No Products need to be ordered");
            }

        }
    }
}
