using CsBases.Fundamentals;

public class ProductRepository
{
    public async Task<Product> GetProduct(int id)
    {
        // Consulta a base de datos,
        // llamado a API externa,
        // lectura de archivo, etc.
        WriteLine("Buscando producto...");
        await Task.Delay(2000);

        return new Product($"Producto {id}", 500);
    }
}