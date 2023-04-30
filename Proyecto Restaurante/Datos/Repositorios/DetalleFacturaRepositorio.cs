using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;

namespace Datos.Repositorios
{
    public class DetalleFacturaRepositorio : IDetalleFacturaRepositorio
    {
        private string CadenaConexon;

        public DetalleFacturaRepositorio(string _cadenaConexion)
        {
            CadenaConexon = _cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexon);
        }

        public async Task<bool> Nuevo(DetalleFactura detalleFactura)
        {
            bool inserto = false;
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = @"INSERT INTO detallefactura (IdDetalleFactura, IdFactura, CodigoProducto, Descripcion,Cantidad, Precio,Total) 
                               VALUES (@IdDetalleFactura, @IdFactura, @CodigoProducto, @Descripcion, @Cantidad, @Precio, @Total);";
                inserto = Convert.ToBoolean(await conexion.ExecuteAsync(sql, detalleFactura));
            }
            catch (Exception ex)
            {
            }
            return inserto;
        }
    }

}

