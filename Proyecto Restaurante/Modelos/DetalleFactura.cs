namespace Modelos
{
    public class DetalleFactura
    {
        public int NumFactura { get; set; }
        public int CodMenu { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal ISV { get; set; }
        public decimal Total { get; set; }

        public DetalleFactura()
        {
        }

        public DetalleFactura(int numFactura, int codMenu, string descripcion, int cantidad, decimal precio, decimal subTotal, decimal descuento, decimal iSV, decimal total)
        {
            NumFactura = numFactura;
            CodMenu = codMenu;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
            SubTotal = subTotal;
            Descuento = descuento;
            ISV = iSV;
            Total = total;
        }
    }
}
