using System.Collections.Generic;

namespace librerias_PMRI.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        //Propiedades de Navegación
        public List<Book_Author> Book_Authors { get; set; }
    }
}
