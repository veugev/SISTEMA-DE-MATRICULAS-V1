using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SISTEMA_DE_MATRICULA_V1.CLASES
{
    class MatencionDatosSQL
    {
        private BdConexion Conexion = new BdConexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;


        public void InsertarAnio(DmantencionTabla dts)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "insert into Anio values('" + dts.get_descripcion() + "')";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }

        public DataTable Listar_anio()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_anio";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            { }
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void Eliminar_anio(DmantencionTabla dts)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "delete Anio where descripcion = '" + dts.get_descripcion() + "'";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }

        // Tabla Comunas

        public void InsertarComunas(DmantencionTabla dts)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "insert into Comuna values('" + dts.get_desc() + "')";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }

        public DataTable Listar_Comuna()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Comuna";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            { }
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void Eliminar_Comuna(DmantencionTabla dts)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "delete Comuna where descripcion = '" + dts.get_desc() + "'";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }


    }
}

