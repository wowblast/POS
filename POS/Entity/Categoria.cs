namespace POS.Entity
{
    public class Categoria
    {

        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Subcategoria { get; set; }

        public Categoria(int idCategoria, string nombre, string descripcion, int subcategoria)
        {
            IdCategoria = idCategoria;
            Nombre = nombre;
            Descripcion = descripcion;
            Subcategoria = subcategoria;
        }

        public Categoria(string nombre, string descripcion, int subcategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Subcategoria = subcategoria;
        }

        public Categoria() { }
    }
}
