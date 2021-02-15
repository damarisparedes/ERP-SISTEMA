namespace BL.Rentas
{
    public class ProductosServicios
    {
        public bool Activos { get; internal set; }
        public int Codigo { get; internal set; }
        public int Costo { get; internal set; }
        public string Descripcion { get; internal set; }
        public int Existencias { get; internal set; }
        public int Precio { get; internal set; }
    }
}