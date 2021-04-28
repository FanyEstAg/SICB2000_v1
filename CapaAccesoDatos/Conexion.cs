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
                //cn.ConnectionString = "Data Source=servidorsqleu2016.database.windows.net Initial Catalog=BDLibreria;User ID=master; Password=123456ed*";
                
                //extracción de datos desde el configuration manager
                //string servidor = ConfigurationManager.Instancia.getServer;
                //string database = ConfigurationManager.Instancia.getDatabase;
                //string user = ConfigurationManager.Instancia.getUser;
                //string clave = ConfigurationManager.Instancia.getClave;


                //cn.ConnectionString = "Data Source="+servidor+"; Initial Catalog = "+
                //    database+"; User ID ="+user+" ; Password ="+clave;

                /*Server = tcp:servidorsqleu2016.database.windows.net,1433; Initial Catalog = BDLibreria;
                Persist Security Info = False; User ID = { your_username }; Password ={ your_password};
                MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;
                */
                return cn;
            }
            catch (Exception){
                throw;
            }
        }


        #endregion metodos

    }
}
