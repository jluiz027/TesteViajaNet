using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace TesteDBServer.Repository
{
    public class InicializaBancoMysql
    {
        private static string scriptCriaBanco = "CREATE DATABASE TesteDBServer";
        private static string scriptCriaTabelaContaCorrente = "USE TesteDBServer; CREATE TABLE ContaCorrente(id varchar(36) PRIMARY KEY,saldoinicial decimal (15,2) NOT NULL)";
        private static string scriptCriaTabelaLancamento = "USE TesteDBServer; CREATE TABLE Lancamento(id varchar(36) PRIMARY KEY, tipoLancamento int NOT NULL, valor decimal (15,2) NOT NULL, idContaCorrente varchar(36) NOT NULL, FOREIGN KEY(idContaCorrente) REFERENCES ContaCorrente(id))";
        private static string sriptInicializaTabelaContaCorrenteComDuaContas = "USE TesteDBServer; INSERT INTO ContaCorrente VALUES('e4ff1fa7-09c7-11ea-a0aa-0242ac110005', 0.0); INSERT INTO ContaCorrente VALUES('25062513-09c8-11ea-a0aa-0242ac110005', 3000.0)";
        public static void CriarAmbiente(string connectionString)
        {
            using (MySqlConnection myConn = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                myConn.Open();

                MySqlCommand myCommand1 = new MySqlCommand(scriptCriaBanco, myConn);
                MySqlCommand myCommand2 = new MySqlCommand(scriptCriaTabelaContaCorrente, myConn);
                MySqlCommand myCommand3 = new MySqlCommand(scriptCriaTabelaLancamento, myConn);
                MySqlCommand myCommand4 = new MySqlCommand(sriptInicializaTabelaContaCorrenteComDuaContas, myConn);

                try
                {
                    myCommand1.ExecuteNonQuery();
                    myCommand2.ExecuteNonQuery();
                    myCommand3.ExecuteNonQuery();
                    myCommand4.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Banco de dados ja criado: {e.Message}");
                    //throw;
                }

            }
            

            
        }
    }
}
