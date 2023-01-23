using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ModernUI
{
    class cl_Login
    {
        cl_ConnectionMySQL db = new cl_ConnectionMySQL();

        public bool LogIn(string l, string p)
        {
            try
            {
                string sqlCmd = $"select login, pass from tbLogin where login like '{l}' and pass like '{p.ToLower()}' ;";

                MySqlCommand cmdLogIn = new MySqlCommand(sqlCmd, db.con);

                db.connect();

                MySqlDataReader objData = cmdLogIn.ExecuteReader();
                if (!objData.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (MySqlException e)
            {
                throw (e);
            }
            finally 
            {
                db.disconnect();
            }
        }

        public string registeringLogin(cl_User user)
        {
            try
            {
                string sql = $"select login from tbLogin where login like '{user.Login}';";

                MySqlCommand cmdLogIn = new MySqlCommand(sql, db.con);

                db.connect();
                    MySqlDataReader objData = cmdLogIn.ExecuteReader();

                if (!objData.HasRows)
                {
                    string sqlCmd = $"insert into tbLogin values ('{user.Login}', '{user.Pass}', '{user.Email}');";

                    MySqlCommand cmdRegisterLgn = new MySqlCommand(sqlCmd, db.con);

                    db.disconnect();
                    db.connect();
                    cmdRegisterLgn.ExecuteNonQuery();

                    return ("Sucessfully Signed Up!");
                }
                else
                {
                    return ("Login already exists!");
                }
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
            finally
            {
                db.disconnect();
            }
        }
    }
}
