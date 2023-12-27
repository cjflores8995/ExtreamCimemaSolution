namespace ExtreamCimemaApp.Models.Models
{
    public class CompraDao
    {
        public int IdCompra { get; set; }
        public int IdCliente { get; set; }
        public int IdProgramacionSala { get; set; }
        public int IdFormaDePago { get; set; }
        public int IdEstadoCompra { get; set; }
        public string CodigoCompra { get; set; }
        public DateTime FechaCompra { get; set; }
        public bool Estado { get; set; }
    }
}
