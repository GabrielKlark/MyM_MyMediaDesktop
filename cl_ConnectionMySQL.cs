using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace ModernUI
{
    class cl_ConnectionMySQL
    {
        //Conexão com o Mysql

        /* school
        public MySqlConnection con = new MySqlConnection(@"Server=localhost;Port=3307;Database=watching;User=root;Pwd=root");
        */

        /* Home */
        public MySqlConnection con = new MySqlConnection(@"Server=localhost;Port=3306;Database=watching;User=root;Pwd=gislaine");
        

        public string connect()
        {
            try
            {
                con.Open();
                return ("Successfully Connected!");
            }
            catch(MySqlException e)
            {
                return (e.ToString());
            }
        }

        public string disconnect()
        {
            try
            {
                con.Close();
                return ("Successfully Disconnected!");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }
    }
}
