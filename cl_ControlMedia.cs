using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ModernUI
{
    class cl_ControlMedia
    {
        //Métodos do projeto (Cadastrar, Alterar, Excluir, Listar...)

        cl_ConnectionMySQL db = new cl_ConnectionMySQL();

        public string registering(cl_Media Media)
        {
            try
            {
                /*
                MySqlCommand cmdReg = new MySqlCommand($"Insert into tb_Media " +
                                                         $"(title_M, date_M, season_M, synopsis_M) " +
                                                         $"values ('{Media.Title_M}', '{Media.Date_M}', '{Media.Season_M}', '{Media.Synopsis_M}');", db.con);

                */
                string sqlCmd;

                if (Media.Season_M == 0)
                {
                    sqlCmd = ($"Call SP_InsertMedia('{ Media.Title_M }',{Media.Date_M}, null,{Media.Synopsis_M});");
                }
                else
                {
                    sqlCmd = ($"Call SP_InsertMedia('{ Media.Title_M }',{Media.Date_M},{Media.Season_M},{Media.Synopsis_M});");
                } 

                MySqlCommand cmdReg = new MySqlCommand(sqlCmd, db.con);
                

                db.connect();
                    cmdReg.ExecuteNonQuery();
                db.disconnect();
                return ("Sucessfully Registered!");
            }
            catch(MySqlException e)
            {
                return (e.ToString());
            }
        }

        public string altering(cl_Media Media)
        {
            try
            {
                //update tb_Media
                //set title_M = "AAA", date_M = null, season_M = null, synopsis_M = null
                //where cod_M = 11;

                /*

                string sqlCmd = ($"update tb_Media" +
                                 $"set title_M = '{Media.Title_M}', date_M = {Media.Date_M}, season_M = {Media.Season_M}, synopsis_M = {Media.Synopsis_M}" +
                                 $"where cod_M = {Media.Cod_M}");

                */

                string sqlCmd;

                if (Media.Season_M == 0)
                {
                    sqlCmd = ($"call SP_AlterMedia({Media.Cod_M}, '{Media.Title_M}', {Media.Date_M}, null, {Media.Synopsis_M})");
                }
                else
                {
                    sqlCmd = ($"call SP_AlterMedia({Media.Cod_M}, '{Media.Title_M}', {Media.Date_M}, {Media.Season_M}, {Media.Synopsis_M})");
                }
                

                MySqlCommand cmdAlt = new MySqlCommand(sqlCmd, db.con);

                db.connect();
                    cmdAlt.ExecuteNonQuery();
                db.disconnect();
                
                return ("Sucessfully Altered!");
            }
            catch(MySqlException e)
            {
                return (e.ToString());
            }
        }

        public string deleting(cl_Media Media)
        {
            try
            {
                //MySqlCommand cmdDel = new MySqlCommand($"Delete from tb_Media where cod_M = {Media.Cod_M};", db.con);

                string sqlCmd = ($"Call SP_DeleteMedia({Media.Cod_M})");

                MySqlCommand cmdDel = new MySqlCommand(sqlCmd, db.con);

                db.connect();
                    cmdDel.ExecuteNonQuery();
                db.disconnect();
                return ("Sucessfully Deleted!");
            }
            catch(MySqlException e)
            {
                return (e.ToString());
            }
        }

        public cl_Media searching(int cod)
        {
            cl_Media Media = new cl_Media();

            try
            {
                string sqlCmd = ($"select * from tb_Media where cod_M = {cod};");

                MySqlCommand cmdSearch = new MySqlCommand(sqlCmd, db.con);

                db.connect();
                {
                    MySqlDataReader objData = cmdSearch.ExecuteReader();

                    if (!objData.HasRows)
                    {
                        return null;
                    }
                    else
                    {
                        objData.Read();
                        Media.Cod_M = Convert.ToInt32(objData["cod_M"]);
                        Media.Title_M = objData["title_M"].ToString();

                        //Date
                        if (objData["date_M"] is null)
                        {
                            Media.Date_M = null;
                        }
                        else
                        {
                            Media.Date_M = objData["date_M"].ToString();
                        }

                        //Season
                        if (objData["season_M"] is DBNull)
                        {
                            Media.Season_M = 0;
                        }
                        else
                        {
                            Media.Season_M = Convert.ToInt32(objData["Season_M"]);
                        }

                        //Synopsis
                        if (objData["Synopsis_M"] is null)
                        {
                            Media.Synopsis_M = null;
                        }
                        else
                        {
                            Media.Synopsis_M = objData["Synopsis_M"].ToString();
                        }


                        objData.Close();
                        return Media;
                    }
                }
            }
            catch (MySqlException e)
            {
                throw e;
            }
            finally
            {
                db.disconnect();
            }
        }

        public DataTable SelectEverything()
        {
            string sqlCmd = "select cod_M as 'Código', title_M as 'Title', date_M as 'Date', season_M as 'Season', synopsis_M as 'Synopsis' from tb_Media;";

            MySqlCommand cmdSE = new MySqlCommand(sqlCmd, db.con);

            db.connect();
                MySqlDataAdapter dt = new MySqlDataAdapter(cmdSE);
                DataTable media = new DataTable();
                dt.Fill(media);
            db.disconnect();

            return media;
        }

        public DataTable SelectCod(int cod)
        {
            string sqlCmd = ($"select cod_M as 'Código', title_M as 'Title', date_M as 'Date', season_M as 'Season', synopsis_M as 'Synopsis' from tb_Media where cod_M = {cod};");

            MySqlCommand cmdSC = new MySqlCommand(sqlCmd, db.con);

            db.connect();
                MySqlDataAdapter dt = new MySqlDataAdapter(cmdSC);
                DataTable media = new DataTable();
                dt.Fill(media);
            db.disconnect();

            return media;
        }

        public DataTable SelectTitle(string title)
        {
            string sqlCmd = ($"select cod_M as 'Code', title_M as 'Title', date_M as 'Date', season_M as 'Season', synopsis_M as 'Synopsis' from tb_Media where title_M like '%{title}%';");

            MySqlCommand cmdST = new MySqlCommand(sqlCmd, db.con);

            db.connect();
                MySqlDataAdapter dt = new MySqlDataAdapter(cmdST);
                DataTable media = new DataTable();
                dt.Fill(media);
            db.disconnect();

            return media;
        }

        public DataTable SelectDate(string date)
        {
            string sqlCmd = ($"select cod_M as 'Code', title_M as 'Title', date_M as 'Date', season_M as 'Season', synopsis_M as 'Synopsis' from tb_Media where date_M like '%{date}%'");

            MySqlCommand cmdSD = new MySqlCommand(sqlCmd, db.con);

            db.connect();
                MySqlDataAdapter dt = new MySqlDataAdapter(cmdSD);
                DataTable media = new DataTable();
                dt.Fill(media);
            db.disconnect();

            return media;
        }

        public DataTable SelectSeason(int season)
        {
            string sqlCmd = ($"select cod_M as 'Code', title_M as 'Title', date_M as 'Date', season_M as 'Season', synopsis_M as 'Synopsis' from tb_Media where season_M = {season}");

            MySqlCommand cmdSNoS = new MySqlCommand(sqlCmd, db.con);

            db.connect();
                MySqlDataAdapter dt = new MySqlDataAdapter(cmdSNoS);
                DataTable media = new DataTable();
                dt.Fill(media);
            db.disconnect();

            return media;
        }

        public DataTable SelectSynopsis(string synopsis)
        {
            string sqlCmd = ($"select cod_M as 'Code', title_M as 'Title', date_M as 'Date', season_M as 'Season', synopsis_M as 'Synopsis' from tb_Media where synopsis_M like '%{synopsis}%'");

            MySqlCommand cmdSS = new MySqlCommand(sqlCmd, db.con);

            db.connect();
                MySqlDataAdapter dt = new MySqlDataAdapter(cmdSS);
                DataTable media = new DataTable();
                dt.Fill(media);
            db.disconnect();

            return media;
        }

        public string dbBackup (string Path)
        {
            string dateNow = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            string pathBackup = ($"{Path}\\backupMedia_{dateNow}.sql");

            try
            {
                MySqlCommand cmdBU = new MySqlCommand(pathBackup, db.con);
                MySqlBackup mb = new MySqlBackup(cmdBU);

                db.connect();
                    mb.ExportToFile(pathBackup);
                db.disconnect();

                return ("Data sucessfully backed up!");
            }
            catch(MySqlException e)
            {
                return (e.ToString());
            }
        }

        public string dbRestore (string Path)
        {
            try
            {
                MySqlCommand cmdRt = new MySqlCommand(Path, db.con);
                MySqlBackup mb = new MySqlBackup(cmdRt);

                db.connect();
                    mb.ImportFromFile(Path);
                db.disconnect();

                return ("Sucessfully restored data from file!");
            }
            catch(MySqlException e)
            {
                return (e.ToString());
            }
        }
    }
}
