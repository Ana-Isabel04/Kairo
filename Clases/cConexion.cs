using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairo.Clases
{
    internal class cConexion
    {
        private static string CadenaConexion =
                 @"Server=localhost\SQLEXPRESS;Database=dbKairo;Trusted_Connection=True;";

        // 📌 Variable de conexión
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        // ✅ Abrir conexión
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();

            return Conexion;
        }

        // ✅ Cerrar conexión
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();

            return Conexion;
        }
    }
}
