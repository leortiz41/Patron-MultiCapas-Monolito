
namespace Biblioteca.Domain.Entities
{
    public class Libro 
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public DateTime DataPublicacion { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}