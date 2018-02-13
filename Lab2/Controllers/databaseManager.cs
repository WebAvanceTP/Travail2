using Microsoft.Data.Sqlite;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Controllers
{
    public class DatabaseManager
    {
        SqliteConnection m_dbConnection;
        readonly char VERSION = '3';

        public DatabaseManager(string[] args)
        {

        }

        private void processArgs(string[] args)
        {
            int nbrCom = 0;
            int nbrPar = -1;

            foreach (string arg in args)
            {
                if (arg.IndexOf('-') != 0)
                    nbrPar++;
                else
                    nbrCom++;
            }
            if (nbrPar != nbrCom)
                throw new Exception("Le nombre de parametres est different que le nombre de commandes");

            for (int i = 0; i < args.Length && i < (nbrPar + 1); i++)
            {
                {
                    if (args[i].IndexOf('-') != 0)
                        continue;
                    processArgs(args[i][1], args[i + nbrCom + 1]);
                }
            }
        }
        private void processArgs(char arg, string param)
        {
            switch (arg)
            {
                case 'n':
                    createNewFile(param);
                    break;
                default:
                    break;
            }
        }

        private void createNewFile(string _name)
        {
            if (File.Exists("../db/" + _name))
                throw new Exception("La base de donnee existe deja");

            string dbString = "Data Source=../db/";
            dbString += _name;
            dbString += ";Version=";
            dbString += VERSION;
            m_dbConnection = new SqliteConnection(dbString);
            m_dbConnection.Open();

            if (m_dbConnection.State != System.Data.ConnectionState.Open)
                throw new Exception("Connection a la base de donnee impossible");

            SqliteCommand sqlCommand;
            string sqlString = "";
            sqlString += "create table user " +
                "(id int, " +
                "nom varchar(20), " +
                "prenom varchar(20), " +
                "username varchar(20)" +
                "password varchar(129)";
            sqlCommand = new SqliteCommand(sqlString, m_dbConnection);
        }
    }
}
