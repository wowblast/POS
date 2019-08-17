namespace POS.Entity
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Cargo { get; set; }

        public Usuario(int idUsuario, string nombre, string apellidoPaterno, string apellidoMaterno, string cargo)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Cargo = cargo;
        }

        public Usuario() { }
    }
}
