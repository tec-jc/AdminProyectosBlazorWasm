namespace AdminProyectosBlazorWasm.Models
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        //public int IdCategoria { get; set; } //.NET
        public int CategoriaId { get; set; } // Java
        public Categoria Categoria { get; set; }
    }
}
