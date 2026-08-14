
 namespace Biblioteca.Domain.Validation
 {
     public class AutorValidation : IAutorValidator
     {
         public required string Name { get; set; }

        public string? Validar(Autor autor)
        {
            if (string.IsNullOrWhiteSpace(autor.Name))
            {
                throw new ArgumentException("El nombre del autor no puede estar vacío.");
            }
            return null;
        }
    }
}