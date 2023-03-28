using System.Linq;
namespace LinqDemo;
class Program
{
    //public delegate int square(int num);

    //static int SquareNumber(int num)
    //{
    //    return (Convert.ToInt32(num * num));
    //}
    static void Main(string[] args)
    {
        //var result = from p in GetProductStores()
        //             select p;

        //foreach(var r in result.SelectMany(ProductStore=>ProductStore.Size))
        //{
        //    Console.WriteLine(r);
        //}
        //Console.ReadLine();
        IList<ProductList> albumLists = new List<ProductList>();
        
        IList<ProductList> productList = new List<ProductList>();

        productList.Add(new ProductList { category = 1, productName = "Hard Disk", type = "MEMORY", productPrice=2000 });
        productList.Add(new ProductList { category = 2, productName = "Monitor", type = "DISPLAY", productPrice = 1200 });
        productList.Add(new ProductList { category = 1, productName = "SSD Disk", type = "MEMORY", productPrice = 800 });
        productList.Add(new ProductList { category = 1, productName = "RAM", type = "MEMORY", productPrice = 700 });
        productList.Add(new ProductList { category = 2, productName = "Processor", type = "CPU", productPrice = 3000 });
        productList.Add(new ProductList { category = 1, productName = "Bluetooth", type = "Accessories", productPrice = 1298 });
        productList.Add(new ProductList { category = 2, productName = "Keyboard & Mouse", type = "Accessories", productPrice = 1234 });

        var result = from p in productList
                     select p.productPrice;

        Console.WriteLine("Average: " + result.Average());
        Console.WriteLine("Count: " + result.Count());
        Console.WriteLine("Max: " + result.Max());
        Console.WriteLine("Min: " + result.Min());
        Console.WriteLine("Sum: " + result.Sum());
        //Console.WriteLine("First Value: " + albumLists.First());
        Console.WriteLine("First Value: " + albumLists.FirstOrDefault());
        Console.WriteLine("Last Value: " + result.Last());
        Console.WriteLine("Is 3500 Available? " + result.Contains(3500));
        Console.WriteLine("Element at 4th Position: " + result.ElementAt(3));

        //var result = productList.ToLookup(p => p.category);
        //foreach (var r in result)
        //{
        //    Console.WriteLine(string.Format("Category: {0}", r.Key));
        //    foreach (var name in r)
        //    {
        //        Console.WriteLine(string.Format("\tProduct Name: {0} | Type: {1}", name.productName, name.type));
        //    }
        //}
        Console.ReadLine();

        //static List<ProductStore> GetProductStores()
        //{
        //    List<ProductStore> products = new List<ProductStore>()
        //    {
        //       new ProductStore
        //       {
        //           Name="Addidas",
        //           Category= "Shoes",
        //           Size = new List<string>{"23", "42", "50"}
        //       },
        //       new ProductStore
        //       {
        //           Name="Nike",
        //           Category= "Shoes",
        //            Size = new List<string>{"small", "medium", "Large"}
        //       },
        //       new ProductStore
        //       {
        //           Name="Lily",
        //           Category= "Shoes",
        //           Size = new List<string>{"10", "20", "30"}
        //       },
        //    };
        //    return products;

    }
}
public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

internal class ProductStore
{
    public string Name { get; set; }
    public string Category { get; set; }
    public List<string> Size { get; set; }   
}
class ProductList
{
    public int category { get; set; }
    public string productName { get; set; }
    public int productPrice { get; set; }
    public string type { get; set; }
}
