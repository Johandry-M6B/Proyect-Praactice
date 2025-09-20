using System.Data.Common;

public class Ventas
{
    public Guid Id { get; set; }
    public DateTime FechaDeVenta { get; set; }
    public decimal MontoTotal { get; set; }
    public int CantidadItems { get; set; }
    public string Vendedor { get; set; } = "";
    public string Comprador { get; set; } = "";
    public TimeSpan TiempoGarantia { get; set; }
    public static void IngresarVenta()
    {
        // Console.WriteLine("Ingrese el monto total de productos vendidos:");
        // Console.WriteLine("Ingrese la cantidad de items vendidos:");
        // Console.WriteLine("Ingrese el nombre del vendedor:");
        // Console.WriteLine("Ingerese el nombre del comprador:");
        // Console.WriteLine("Ingrese los datos el orde que se le solicito anteriormente");
        var Venta = new Ventas()
        {
            Id = Guid.NewGuid(),
            FechaDeVenta = DateTime.Now,
            MontoTotal = 1250.50m,
            CantidadItems = 5,
            Vendedor = "Juan" ?? "",
            Comprador = "PAblo" ?? "",
            TiempoGarantia = TimeSpan.FromDays(365)

        };
        
        
    }
     static void MonstarVentas(Ventas Venta)
    {
        


                Console.WriteLine("Lista de ventas realizadas:");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"ID: {Venta.Id}");
                Console.WriteLine($"Fecha de Venta: {Venta.FechaDeVenta:dd/MM/yyyy HH:mm}");
                Console.WriteLine($"Monto Total: {Venta.MontoTotal:C}");
                Console.WriteLine($"Cantidad de Items:{Venta.CantidadItems}");
                Console.WriteLine($"Vendedor:{Venta.Vendedor}");
                Console.WriteLine($"Comprador:{Venta.Comprador}");
                Console.WriteLine($"Tiempo de Garantia: {Venta.TiempoGarantia.TotalDays} Dias");
                Console.WriteLine("--------------------------------------------------");
            }
           
    
    
}
