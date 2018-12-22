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
    class PadreSQL
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

        public void InsertarPadre(Dpadre dtp)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "insert into Padre values('" + dtp.get_rut_pa() + "','" + dtp.get_nombre_pa() + "','" + dtp.get_nacionalidad_pa() + "'," +
                                                            "'" + dtp.get_direccion_pa() + "','" + dtp.get_comuna_pa() + "','" + dtp.get_nivel_educacional_pa() + "'," +
                                                            "'" + dtp.get_ocupacion_pa() + "','" + dtp.get_fono_pa() + "','" + dtp.get_parentezco_pa() + "'," +
                                                            "'" + dtp.get_mail_pa() + "')";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }

        public DataTable Listar_Padres()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Listar_Padres";
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

        public void Modificarpadre(Dpadre dtp)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Update Padre  set Nombre_padre = '" + dtp.get_nombre_pa() + "', Nacionalidad= '" + dtp.get_nacionalidad_pa() + "'," +
                                                            "Direccion = '" + dtp.get_direccion_pa() + "', id_comuna = '" + dtp.get_comuna_pa() + "', Nivel_educ = '" + dtp.get_nivel_educacional_pa() + "'," +
                                                            " Ocupacion = '" + dtp.get_ocupacion_pa() + "', Fono ='" + dtp.get_fono_pa() + "', id_parentezco = '" + dtp.get_parentezco_pa() + "'," +
                                                            "Mail = '" + dtp.get_mail_pa() + "'where id_RutP = '" + dtp.get_rut_pa() + "'";
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }

    }
}
