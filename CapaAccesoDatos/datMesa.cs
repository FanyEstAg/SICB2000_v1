﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Entidades;

namespace CapaAccesoDatos
{
    public class datMesa
    {
        #region singleton
        private static readonly datMesa _intancia = new datMesa();
        public static datMesa Instancia
        {
            get { return datMesa._intancia; }
        }
        #endregion singleton

        #region metodos mesa
       
        public int EliminarMesa(int id_mesa)
        {//LISTO
            SqlCommand cmd = null;
            var retorno = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspEliminarMesa", cn);
                cmd.Parameters.AddWithValue("@prmId_Mesa", id_mesa);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                retorno = cmd.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
        }

        public int insertarMesa(string cadXml)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspInsertarMesa", cn);
                cmd.Parameters.AddWithValue("@CadXml", cadXml);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                var result = cmd.ExecuteNonQuery();
                cn.Close();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int insertarTipoMesa(String nom)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspInsertarTipoMesa", cn);
                cmd.Parameters.AddWithValue("@prmNombreTipo", nom);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                var result = cmd.ExecuteNonQuery();
                cn.Close();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int actualizarMesa(String cadXml)//LISTO
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspActualizarMesa", cn);
                cmd.Parameters.AddWithValue("@Cadxml", cadXml);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                var result = cmd.ExecuteNonQuery();
                cn.Close();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<entTipo> ListarTipo()
        {//--listo
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entTipo> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspListaTipo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entTipo>();
                while (dr.Read())
                {
                    entTipo t = new entTipo();
                    t.Id_Tipo = Convert.ToInt32(dr["Id_tipo"].ToString());
                    t.Nom_Tipo = dr["Nom_tipo"].ToString();
                    Lista.Add(t);
                    //MessageBox.Show("" + Lista);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public int ObtenerIdMesa()//---listo
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            int r = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspObtenerIdMesa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    r = Convert.ToInt32(dr["Id_mesa"]);
                }
                cn.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return r;
        }

        public DataTable CargarMesas()//LISTO
        {//listo
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspCargarMesas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dt.Load(cmd.ExecuteReader());

            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return dt;
        }
        public DataTable BuscarMesa(string busqueda)
        {//
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspBuscarMesa", cn);
                cmd.Parameters.AddWithValue("@prmBusqueda", busqueda);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dt.Load(cmd.ExecuteReader());

            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return dt;
        }


        #endregion mesa

        #region metodos Cobro
        
        public int GuardarCobroMesa(String cadXml)//modifcar
        {
            SqlCommand cmd = null;
            var result = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspGuardarCobroMesa", cn);
                cmd.Parameters.AddWithValue("@Cadxml", cadXml);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
        }

        public List<entMesa> ListarMesa()
        {//--listo
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entMesa> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspListaMesas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entMesa>();
                while (dr.Read())
                {
                    entMesa m = new entMesa();
                    entTipo t = new entTipo();
                    m.Id_Mesa = Convert.ToInt32(dr["Id_mesa"].ToString());

                    t.Id_Tipo= Convert.ToInt32(dr["Id_tipo"].ToString());
                    t.Nom_Tipo= dr["Nom_tipo"].ToString();
                    m.id_tipo = t;
                    Lista.Add(m);
                    //MessageBox.Show("" + Lista);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public string ListarTipoMesa(int idMesa)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string r = "";
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspMostrarTipoMesa", cn);
                cmd.Parameters.AddWithValue("@prmMesa", idMesa);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    r = dr["Nom_tipo"].ToString();
                }
                cn.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return r;
        }

        public DataTable BuscarCobro(int id)//LISTO
        {
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspBuscarCobro", cn);
                cmd.Parameters.AddWithValue("@prmIdCobro", id);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dt.Load(cmd.ExecuteReader());

            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return dt;
        }
        public DataTable CargarCobros()//LISTO
        {
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspCargarCobros", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dt.Load(cmd.ExecuteReader());

            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return dt;
        }
        #endregion metodos Cobro
    }
}
