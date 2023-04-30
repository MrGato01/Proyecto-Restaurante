using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;

namespace Datos.Repositorios
{
    public class ClientesRepositorio : IClientesRepositorio
    {
        private string CadenaConexion;

        public ClientesRepositorio(string _cadenaConexion)
        {
            CadenaConexion = _cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }


        public async Task<bool> Actualizar(Clientes cliente)
        {
            bool resultado = false;

            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = @"UPDATE cliente SET Nombre = @Nombre, Direccion = @Direccion, FechaNacimiento = @FechaNacimiento, Correo = @Correo, Telefono = @Telefono
                               WHERE Identidad = @Identidad;";
                resultado = Convert.ToBoolean(await _conexion.ExecuteAsync(sql, cliente));
            }

            catch (Exception)
            {

            }
            return resultado;
        }

        public async Task<bool> Eliminar(string DNIcliente)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "DELETE FROM cliente WHERE Identidad = @Identidad;";
                resultado = Convert.ToBoolean(await _conexion.ExecuteAsync(sql, new { DNIcliente }));
            }

            catch (Exception)
            {

            }
            return resultado;
        }

        public async Task<IEnumerable<Clientes>> GetLista()
        {
            IEnumerable<Clientes> lista = new List<Clientes>();
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "SELECT * FROM cliente;";
                lista = await _conexion.QueryAsync<Clientes>(sql);
            }

            catch (Exception)
            {

            }
            return lista;
        }

        public async Task<Clientes> GetPorCodigo(string DNIcliente)
        {
            Clientes client = new Clientes();
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "SELECT * FROM cliente WHERE Identidad = @Identidad;";
                client = await _conexion.QueryFirstAsync<Clientes>(sql, new { DNIcliente });
            }

            catch (Exception)
            {

            }
            return client;
        }

        public async Task<bool> Nuevo(Clientes cliente)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = @"INSERT INTO cliente (Nombre, Direccion, FechaNacimiento, Correo, Telefono)
                              VALUES (@Nombre, @Direccion, @FechaNacimiento, @Correo, @Telefono) ";
                resultado = Convert.ToBoolean(await _conexion.ExecuteAsync(sql, cliente));
            }

            catch (Exception)
            {

            }
            return resultado;
        }
    }
}
