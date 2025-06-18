using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListaTarefas.Model
{
    internal class Banco
    {
        // Objeto de conexão SQL:
        public SQLiteConnection conexao;
        // Contrutor de conexão:
        public Banco()
        {
            // Apontar onde estará nosso arquivo de banco de dados:
            conexao = new SQLiteConnection("Data Source=banco.sql3.db");
            // Verificar se o arquivo banco.sqlite3 NÃO existe:
            if (!File.Exists("./banco.sql3.db"))
            {
                // Criar o arquivo de banco de dados:
                SQLiteConnection.CreateFile("banco.sql3.db");
            }
        }
        // Método para conectar:
        public void Conectar()
        {
            // Verificar se a conexão não está aberta:
            if (conexao.State != ConnectionState.Open)
            {
                // Abrir a conexão:
                conexao.Open();
            }
        }

        // Método para desconectar:
        public void Desconectar()
        {
            // Verificar se a conexão não está fechada:
            if (conexao.State != ConnectionState.Closed)
            {
                // Fechar a conexão:
                conexao.Close();
            }
        }
    }

   
}
