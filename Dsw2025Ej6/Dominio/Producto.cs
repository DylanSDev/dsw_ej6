namespace Dsw2025Ej6.Dominio;

internal class Producto
{
    private long _codigo;
    private string _descripcion;
    private bool _activo;
    private double _precioVenta;
    private float _impuesto = 0.21f;
    private int _stock;
    private char _presentacion;
    private DateTime _fechaAlta;

    public long GetCodigo()
    {
        return _codigo;
    }

    public void SetCodigo(long codigo)
    {
        _codigo = codigo;
    }

    public string GetDescripcion()
    {
        return _descripcion;
    }

    public void SetDescripcion(string descripcion)
    {
        _descripcion = descripcion;
    }

    public bool GetActivo()
    {
        return _activo;
    }

    public void SetActivo(bool activo)
    {
        _activo = activo;
    }

    public double GetPrecioVenta()
    {
        return _precioVenta;
    }

    public void SetPrecioVenta(double precioVenta)
    {
        _precioVenta = precioVenta;
    }

    public float GetImpuesto()
    {
        return _impuesto;
    }

    public void SetImpuesto(float impuesto)
    {
        _impuesto = impuesto;
    }

    public int GetStock()
    {
        return _stock;
    }

    public void SetStock(int stock)
    {
        _stock = stock;
    }

    public char GetPresentacion()
    {
        return _presentacion;
    }

    public void SetPresentacion(char presentacion)
    {
        _presentacion = presentacion;
    }

    public DateTime GetFechaAlta()
    {
        return _fechaAlta;
    }

    public void SetFechaAlta(DateTime fechaAlta)
    {
        _fechaAlta = fechaAlta;
    }

    public double CalcularPrecioSinImpuesto()
    {
        return _precioVenta / (1 + _impuesto);
    }

    public string ObtenerDescripcionProducto()
    {
        return $"[{_codigo}] {_descripcion} [{_presentacion}]: {_precioVenta:C}";
    }

    public void incrementarStockEnUno()
    {
        _stock++;
    }

    public void decrementarStockEnUno()
    {
        _stock--;
    }

    public void incrementarStockEnCantidad(int cantidad)
    {
        _stock += cantidad;
    }
}