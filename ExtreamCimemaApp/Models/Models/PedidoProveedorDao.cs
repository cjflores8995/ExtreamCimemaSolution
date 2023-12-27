namespace ExtreamCimemaApp.Models.Models
{
    public class PedidoProveedorDao
    {
        public int IdPedidoProveedor { get; set; }
        public int IdProveedor { get; set; }
        public int IdPelicula { get; set; }
        public int IdEstadoPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public bool Estado { get; set; }
    }
}
