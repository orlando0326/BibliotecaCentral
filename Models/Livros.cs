using Microsoft.EntityFrameworkCore;

namespace BibliotecaCentral.Models
{
    public class Livros
    {
        public int id { get; set; } PrimaryKeyAttribute PrimaryKey { get; set; }

        public DateTime DataPublicado { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public int Codigo { get; set; }
    }
}
