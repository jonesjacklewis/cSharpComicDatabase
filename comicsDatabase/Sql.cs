// SQL Functions based on: https://www.codeguru.com/dotnet/using-sqlite-in-a-c-application/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;

namespace comicsDatabase
{
    class Sql
    {
        // Class Variables
        SQLiteConnection conn;  
        readonly Files logger = new Files("sqlLogs.log");

        public Sql(string databaseName)
        {
            conn = CreateConnection(databaseName);  // Creates Connection, Constructor

        }


        private SQLiteConnection CreateConnection(String databaseName)
        {
            FormattableString connDetails = $"Data Source={databaseName}.db; Version = 3; New = True; Compress = True;"; // Connection String

            SQLiteConnection sqliteConn;
            // Create a new database connection:
            sqliteConn = new SQLiteConnection(connDetails.ToString());
            // Open the connection:
            try
            {
                sqliteConn.Open();
            }
            catch (Exception ex)
            {
                logger.WriteLine(ex.Message); // If fails logs
            }
            return sqliteConn;
        }

        public bool InsertOrDeleteRow(String command)
        {
            try
            {
                SQLiteCommand sqliteCmd;
                sqliteCmd = conn.CreateCommand();
                sqliteCmd.CommandText = command;
                sqliteCmd.ExecuteNonQuery();
                return true;
            } catch (Exception ex)
            {
                logger.WriteLine(ex.Message);
                return false;
            }

        }

        public int GetNumberOfColumns(String tableName)
        {
            try
            {
                SQLiteDataReader sqliteDataReader;
                SQLiteCommand sqliteCmd;


                sqliteCmd = conn.CreateCommand();
                sqliteCmd.CommandText = "SELECT * FROM " + tableName + ";";
                sqliteDataReader = sqliteCmd.ExecuteReader();


                return sqliteDataReader.FieldCount;
            }catch(Exception ex)
            {
                logger.WriteLine(ex.Message);
                return -1;
            }
            

        } 

        public ArrayList GetAllValues(String tableName)
        {
            try
            {
                SQLiteCommand sqliteCmd;
                SQLiteDataReader sqliteDataReader;

                sqliteCmd = conn.CreateCommand();
                sqliteCmd.CommandText = "SELECT * FROM " + tableName + ";";
                sqliteDataReader = sqliteCmd.ExecuteReader();

                var rows = new ArrayList();

                while (sqliteDataReader.Read())
                {
                    rows.Add(sqliteDataReader.GetValues()); // Gets values as object array
                }

                return rows;
                
            }
            catch (Exception ex)
            {
                logger.WriteLine(ex.Message);
                return new ArrayList();
            }
        }

        public ArrayList GetAllValuesCondition(String tableName, String condition)
        {
            try
            {
                SQLiteCommand sqliteCmd;
                SQLiteDataReader sqliteDataReader;

                sqliteCmd = conn.CreateCommand();
                sqliteCmd.CommandText = "SELECT * FROM " + tableName + " where " + condition + ";";
             
                sqliteDataReader = sqliteCmd.ExecuteReader();

                var rows = new ArrayList();

                while (sqliteDataReader.Read())
                {
                    rows.Add(sqliteDataReader.GetValues()); // Gets values as object array
                }

                return rows;

            }
            catch (Exception ex)
            {
                logger.WriteLine(ex.Message);
                return new ArrayList();
            }
        }

        public NameValueCollection GetValue(String command)
        {
            try
            {
                SQLiteCommand sqliteCmd;
                SQLiteDataReader sqliteDataReader;

                sqliteCmd = conn.CreateCommand();
                sqliteCmd.CommandText = command;
                sqliteDataReader = sqliteCmd.ExecuteReader();

                NameValueCollection value = new NameValueCollection();

                while (sqliteDataReader.Read())
                {
                   value = sqliteDataReader.GetValues(); // Gets values as object array
                }

                return value;

            }
            catch (Exception ex)
            {
                logger.WriteLine(ex.Message);
                return new NameValueCollection();
            }
        }

        public void InsertBlob(String command, byte[] blob)
        {
            try
            {
                SQLiteCommand sqliteCmd;
                sqliteCmd = conn.CreateCommand();

                sqliteCmd.CommandText = command;
                SQLiteParameter parameter = new SQLiteParameter("@image", System.Data.DbType.Binary);
                parameter.Value = blob;
                sqliteCmd.Parameters.Add(parameter);

                MessageBox.Show(sqliteCmd.CommandText);

                int rowsUpdated = sqliteCmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorr Adding Item " + ex.Message);
            }
        }

        public byte[] getByteArray(String command, int parameter)
        {
            try
            {
                SQLiteCommand sqliteCmd;
                SQLiteDataReader sqliteDataReader;

                sqliteCmd = conn.CreateCommand();
                sqliteCmd.CommandText = command;
                sqliteDataReader = sqliteCmd.ExecuteReader();

                byte[] binDate = new byte[] { };



                while (sqliteDataReader.Read())
                {
                    binDate = (byte[])sqliteDataReader.GetValue(parameter);
                }

             

                return binDate;

            }
            catch (Exception ex)
            {
                logger.WriteLine(ex.Message);
                Byte[] value = new byte[] { };

                return value;
            }
        }


    }
}