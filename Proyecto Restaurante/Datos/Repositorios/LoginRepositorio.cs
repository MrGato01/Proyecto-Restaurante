﻿using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class LoginRepositorio : ILoginRepositorio
    {
        private string CadenaConexion; 

        public LoginRepositorio (string _cadenaConexion)
        {
            CadenaConexion= _cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection( CadenaConexion);
        }

        public async Task<bool> ValidarUsuario(Login login)
        {
            bool valido = false;
            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                
                    
            }
            catch (Exception)
            {

            }

        }

    }
}

