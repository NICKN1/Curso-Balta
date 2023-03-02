
//O tipo da propriedade pode ser 'var' 
//var mouse = new Product()
Product mouse = new Product(1, "mouse", 99.99, EProductType.Product);
var manutecaoEletrica = new Product(2, "Manutenção Elétrica Residencial", 200.00, EProductType.Service);

Console.WriteLine(mouse.Id);
Console.WriteLine(mouse.Name);
Console.WriteLine(mouse.Price);
Console.WriteLine(mouse.Type);
Console.WriteLine((int)mouse.Type); //CONVERSOR EXPLÍCITO

Console.WriteLine(manutecaoEletrica.Id);
Console.WriteLine(manutecaoEletrica.Name);
Console.WriteLine(manutecaoEletrica.Price);
Console.WriteLine(manutecaoEletrica.Type);
struct Product
{
    public Product(int id, string name, double price, EProductType type)
    {
        Id = id;
        Name = name;
        Price = price;
        Type = type;
    }
    
    public int Id;
    public string Name;
    public double Price;
    public EProductType Type;

    public double PriceInDolar(double dolar)
    {
        return Price * dolar;
    }
}

    enum EProductType
    {
        Product = 1,
        Service = 2
    }