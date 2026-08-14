
namespace Biblioteca.Domain.Entities
{
    public class Autor  
    {
        public required string Name { get; set; }
        public required string Nacionalidade { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime? DataFalecimento { get; set; }
    }
}