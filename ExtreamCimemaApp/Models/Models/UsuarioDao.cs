namespace ExtreamCimemaApp.Models.Models
{
    public class UsuarioDao
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool Estado { get; set; }
    }
}
