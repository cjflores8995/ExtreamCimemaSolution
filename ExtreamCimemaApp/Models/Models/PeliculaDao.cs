namespace ExtreamCimemaApp.Models.Models
{
    public class PeliculaDao
    {
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string UrlTrailer { get; set; }
        public int Duracion { get; set; }
        public string Elenco { get; set; }
        public DateTime FechaEstreno { get; set; }
        public bool EstaProyectandose { get; set; }
        public bool ExisteEnStock { get; set; }
        public bool Estado { get; set; }
    }
}
