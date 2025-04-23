using Dsw2025Ej6.Dominio;

namespace Dsw2025Ej6;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n Probamos el codigo de la clase Producto\n");

        // Crear una instancia de la clase Producto
        Producto prod = new Producto();

        // Usar los métodos Set para asignar valores
        prod.SetCodigo(12345);
        prod.SetDescripcion("Producto A");
        prod.SetPresentacion('B');
        prod.SetPrecioVenta(1500.75);
        prod.SetStock(100);
        prod.SetActivo(true);
        prod.SetFechaAlta(DateTime.Now);

        // Mostrar la descripción del producto usando el método ObtenerDescripcionProducto()
        Console.WriteLine(prod.ObtenerDescripcionProducto());

        // Mostrar el precio sin impuesto
        Console.WriteLine($"- Precio sin impuesto: {prod.CalcularPrecioSinImpuesto():C}");

        // Incrementar y decrementar el stock
        prod.incrementarStockEnUno();
        Console.WriteLine($"- Stock después de incrementar en 1: {prod.GetStock()}");

        prod.decrementarStockEnUno();
        Console.WriteLine($"- Stock después de decrementar en 1: {prod.GetStock()}");

        // Incrementar el stock en una cantidad específica
        prod.incrementarStockEnCantidad(50);
        Console.WriteLine($"- Stock después de incrementar en 50: {prod.GetStock()}");

        // Finaliza el programa
        Console.WriteLine("\n Programa ejecutado con éxito.");
    }
}