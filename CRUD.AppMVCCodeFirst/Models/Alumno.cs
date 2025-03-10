namespace CRUD.AppMVCCodeFirst.Models
{
    public class Alumno
    {

        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime FechaNacimieno { get; set; } = DateTime.Now;
        public short YearEstudio { get; set; }

    }
}
