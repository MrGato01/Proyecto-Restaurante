using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;
namespace Datos.Repositorios
{
    public class ProductoRepositorio : IProductoRepositorio
    {
        private string CadenaConexion;

        public ProductoRepositorio(string _cadenaConexion)
        {
            CadenaConexion = _cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }


        public async Task<bool> Actualizar(Producto producto)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();

                string sql = @"UPDATE producto SET TipoProducto = @TipoProducto, Nombre = @Nombre, Descripcion = @Descripcion, Existencia = @Existencia, 
                              Precio = @Precio, FechaVencimiento = @FechaVencimiento, EstaActivo = @EstaActivo WHERE CodigoProducto=@CodigoProducto;";
                resultado = Convert.ToBoolean(await conexion.ExecuteAsync(sql, producto));
            }
            catch (Exception)
            {
            }
            return resultado;
        }

        public async Task<bool> Eliminar(string CodigoProducto)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();

                string sql = "DELETE FROM producto WHERE CodigoProducto=@CodigoProducto;";
                resultado = Convert.ToBoolean(await conexion.ExecuteAsync(sql, new { CodigoProducto }));
            }
            catch (Exception)
            {
            }
            return resultado;
        }

        public async Task<IEnumerable<Producto>> GetLista()
        {
            IEnumerable<Producto> lista = new List<Producto>();
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();

                string sql = "SELECT * FROM producto;";
                lista = await conexion.QueryAsync<Producto>(sql);
            }
            catch (Exception)
            {
            }
            return lista;
        }

        public async Task<Producto> GetPorCodigo(string CodigoProducto)
        {
            Producto prod = new Producto();
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();

                string sql = "SELECT * FROM producto WHERE CodigoProducto = @CodigoProducto;";
                prod = await _conexion.QueryFirstAsync<Producto>(sql, new { CodigoProducto });
            }
            catch (Exception)
            {
            }
            return prod;
        }

        public async Task<bool> Nuevo(Producto producto)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();

                string sql = @"INSERT INTO producto (CodigoProducto, TipoProducto, Nombre, Descripcion, Existencia, Precio, FechaVencimiento, EstaActivo) 
                               VALUES (@CodigoProducto, @TipoProducto, @Nombre, @Descripcion, @Existencia, @Precio, @FechaVencimiento, @EstaActivo);";
                resultado = Convert.ToBoolean(await _conexion.ExecuteAsync(sql, producto));
            }
            catch (Exception)
            {
            }
            return resultado;
        }
    }
}
