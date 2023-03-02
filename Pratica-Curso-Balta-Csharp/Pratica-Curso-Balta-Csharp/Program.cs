
//O tipo da propriedade pode ser 'var' 
//var mouse = new Product()
Product mouse = new Product(1, "mouse", 99.99);

Console.WriteLine(mouse.Id);
Console.WriteLine(mouse.Name);
Console.WriteLine(mouse.Price);

struct Product
{
    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
    
    public int Id;
    public string Name;
    public double Price;

    public double PriceInDolar(double dolar)
    {
        return Price * dolar;
    }
}