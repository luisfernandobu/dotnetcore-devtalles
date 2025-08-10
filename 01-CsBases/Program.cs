using System.Threading.Tasks;
using CsBases.Fundamentals;

class Program
{
    static async Task Main()
    {
        var laptop = new Product("Laptop", 1500);
        // WriteLine(laptop.GetDescription());

        var soporte = new ServiceProduct("Soporte téctico", 300, 30);
        // WriteLine(soporte.GetDescription());

        var product = new Product("Mouse Gamer", 300);
        var productDto = ProductAdapter.ToDto(product);
        // WriteLine($"{productDto.Name} - {productDto.Price:C} - Código: {productDto.Code}");

        // Inyección de dependencias
        ILabelService labelService = new LabelService();
        var manager = new ProductManager(labelService);
        var monitor = new Product("Monitor 27\"", 150);
        var installation = new ServiceProduct("Instalación de monitor", 20, 30);
        // manager.PrintLabel(monitor);
        // manager.PrintLabel(installation);

        var product1 = await new ProductRepository().GetProduct(1);
        product1.Description = "Loreim ipsum dolor amet";
        AttributeProcessor.ApplyUpperCase(product1);
        WriteLine($"{product1.Name} - {product1.Price} - {product1.Description}");
    }
}
