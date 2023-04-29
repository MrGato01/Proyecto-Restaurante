namespace Modelos
{
    public class Factura
    {
        public DateTime Fecha { get; set; }
        public int NumFactura { get; set; }
        public string CodUsuario { get; set; }
        public string Cliente { get; set; }
        public string IdCliente { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal ISV { get; set; }
        public decimal Total { get; set; }

        public Factura()
        {
        }

        public Factura(DateTime Fecha_, int NumFactura_, string CodUsuario_, string Cliente_, string IdCliente_, decimal SubTotal_, decimal Descuento_, decimal ISV_, decimal Total_)
        {
            Fecha = Fecha_;
            NumFactura = NumFactura_;
            CodUsuario = CodUsuario_;
            Cliente = Cliente_;
            IdCliente = IdCliente_;
            SubTotal = SubTotal_;
            Descuento = Descuento_;
            ISV = ISV_;
            Total = Total_;

        }
    }
}
