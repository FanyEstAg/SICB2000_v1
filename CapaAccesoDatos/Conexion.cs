using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        #region conexion
        private static readonly Conexion _instancia = new Conexion();//buscar que es readonly
        public static Conexion Instancia {
            get {
                return Conexion._instancia;
            }
        }
        #endregion conexion

        #region metodos

   

        public SqlConnection Conectar() {
            try{
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Data Source=LAPTOP-F9VT67M5\\SQLSERVER2019; Initial Catalog=bd_billar; Integrated Security=true ";
                
                return cn;
            }
            catch (Exception){
                throw;
            }
        }


        #endregion metodos

    }
}
