namespace ExtreamCimemaApp.Models.Models
{
    public class ClienteDao
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int? IdUsuario { get; set; }
        public bool? Estado { get; set; }
    }
}
