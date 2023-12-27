namespace ExtreamCimemaApp.Models.Models
{
    public class ProgramacionSalaDao
    {
        public int IdProgramacionSala { get; set; }
        public int? IdSala { get; set; }
        public int? IdPelicula { get; set; }
        public DateTime? FechaInicio { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public bool? Estado { get; set; }
    }
}
