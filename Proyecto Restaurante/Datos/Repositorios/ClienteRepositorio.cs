using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;

namespace Datos.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private string CadenaConexion;

        public ClienteRepositorio(string _cadenaConexion)
        {
            CadenaConexion = _cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }


        public async Task<bool> Actualizar(Cliente cliente)
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

        public async Task<bool> Eliminar(string identidad)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "DELETE FROM cliente WHERE Identidad = @Identidad;";
                resultado = Convert.ToBoolean(await _conexion.ExecuteAsync(sql, new { identidad }));
            }

            catch (Exception)
            {

            }
            return resultado;
        }

        public async Task<IEnumerable<Cliente>> GetLista()
        {
            IEnumerable<Cliente> lista = new List<Cliente>();
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "SELECT * FROM cliente;";
                lista = await _conexion.QueryAsync<Cliente>(sql);
            }

            catch (Exception)
            {

            }
            return lista;
        }

        public async Task<Cliente> GetPorIdentidad(string identidad)
        {
            Cliente client = new Cliente();
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "SELECT * FROM cliente WHERE Identidad = @Identidad;";
                client = await _conexion.QueryFirstAsync<Cliente>(sql, new { identidad });
            }

            catch (Exception)
            {

            }
            return client;
        }

        public async Task<bool> Nuevo(Cliente cliente)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = @"INSERT INTO cliente (Identidad, Nombre, Direccion, FechaNacimiento, Correo, Telefono)
                              VALUES (@Identidad, @Nombre, @Direccion, @FechaNacimiento, @Correo, @Telefono) ";
                resultado = Convert.ToBoolean(await _conexion.ExecuteAsync(sql, cliente));
            }

            catch (Exception)
            {

            }
            return resultado;
        }
    }
}
