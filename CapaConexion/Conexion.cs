using System.Data.SqlClient;
using System.Data;

namespace CapaConexion
{
    public class Conexion
    {
        private string cadena = "Server=localhost\\SQLEXPRESS;Database=la_fortuna;Trusted_Connection=True;";
        private SqlConnection cn;

        public SqlConnection conectar_db()
        {
            cn = new SqlConnection(cadena);

            if (cn.State == ConnectionState.Open)
            {

                cn.Close();
            }
            else
            {
                cn.Open();
            }

            return cn;

        }

    }
}
