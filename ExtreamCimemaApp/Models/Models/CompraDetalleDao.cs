namespace ExtreamCimemaApp.Models.Models
{
    public class CompraDetalleDao
    {
        public int IdCompraDetalle { get; set; }
        public int IdCompra { get; set; }
        public int IdAsiento { get; set; }
        public bool Estado { get; set; }
    }
}
