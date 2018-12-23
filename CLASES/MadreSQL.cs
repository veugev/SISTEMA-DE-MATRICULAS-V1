using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SISTEMA_DE_MATRICULA_V1.CLASES
{
    class MadreSQL
    {
        private BdConexion Conexion = new BdConexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable Listar_Comuna()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Comuna";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void InsertarPadre(Dmadre dtp)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "insert into Madre values('" + dtp.get_rut_ma() + "','" + dtp.get_nombre_ma() + "','" + dtp.get_nacionalidad_ma() + "'," +
                                                            "'" + dtp.get_direccion_ma() + "','" + dtp.get_comuna_ma() + "','" + dtp.get_nivel_educacional_ma() + "'," +
                                                            "'" + dtp.get_ocupacion_ma() + "','" + dtp.get_fono_ma() + "','" + dtp.get_parentezco_ma() + "'," +
                                                            "'" + dtp.get_mail_ma() + "')";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }

        public DataTable Listar_Madres()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Madres";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            { }
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable Listar_Parentezco()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_parentezco";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            { }
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void Modificarmadre(Dmadre dtp)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Update Madre  set Nombre_madre = '" + dtp.get_nombre_ma() + "', Nacionalidad= '" + dtp.get_nacionalidad_ma() + "'," +
                                                            "Direccion = '" + dtp.get_direccion_ma() + "', id_comuna = '" + dtp.get_comuna_ma() + "', Nivel_educ = '" + dtp.get_nivel_educacional_ma() + "'," +
                                                            " Ocupacion = '" + dtp.get_ocupacion_ma() + "', Fono ='" + dtp.get_fono_ma() + "', id_parentezco = '" + dtp.get_parentezco_ma() + "'," +
                                                            "Mail = '" + dtp.get_mail_ma() + "'where id_RutM = '" + dtp.get_rut_ma() + "'";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }
    }
}
