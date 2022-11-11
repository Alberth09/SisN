using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class Base
    {
        MySqlConnection con;
        public Base(string servidor, string usuario, string clave, string based)
        {
            con = new MySqlConnection(string.Format("server={0}; user={1}; password={2}; database={3};", servidor, usuario, clave
                , based));
        }

        public string Comando(string q)
        {
            try
            {
                MySqlCommand c = new MySqlCommand(q, con);
                con.Open();
                c.ExecuteNonQuery();
                con.Close();
                return "Correcto";
            }
            catch (Exception ex)
            {
                con.Close();
                return ex.Message;
            }
        }

        public DataSet Mostrar(string q, string table)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(q, con);
                con.Open();
                da.Fill(ds, table);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                con.Close();
                return ds;
            }
        }
    }
}
