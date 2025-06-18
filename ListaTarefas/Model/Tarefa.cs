using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTarefas.Model
{
    internal class Tarefa
    {
        public int Id { get; set; }
        public DateTime Data_Limite { get; set; }
        public string Nome_Tarefa { get; set; }
        public int Prioridade { get; set; }

        public int Cadastrar()
        {
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            banco.Conectar();

            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();

            // Definir o comando SQL com parâmetros:
            cmd.CommandText = "INSERT INTO Tarefas (Data_Limite, Nome_Tarefa, Prioridade) VALUES (@Data_Limite, @Nome_Tarefa, @Prioridade)";

            // Adicionar valores aos parâmetros:
            cmd.Parameters.AddWithValue("@Data_Limite", this.Data_Limite.ToString("dd/MM/yyyy"));
            cmd.Parameters.AddWithValue("@Prioridade", this.Prioridade);
            cmd.Parameters.AddWithValue("@Nome_Tarefa", this.Nome_Tarefa);

            // Executar e capturar a quantidade de linhas inseridas/removidas:
            int linhasAfetadas = cmd.ExecuteNonQuery();

            // Desconectar
            banco.Desconectar();

            // Retornar a quantidade de linhas inseridas
            return linhasAfetadas; 
        }

        public DataTable ListarTudo()
        {
            DataTable tabela = new DataTable();
            Banco banco = new Banco();
            banco.Conectar();
            var cmd = banco.conexao.CreateCommand();
            cmd.CommandText = "SELECT * FROM Tarefas ";
            cmd.Parameters.AddWithValue("tarefa", this.Nome_Tarefa);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(tabela);
            banco.Desconectar();
            return tabela;
        }

              public int Apagar()
        {
            Banco banco = new Banco();
            banco.Conectar();

            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();

            // Definir o comando SQL com parâmetros:
            cmd.CommandText = "DELETE FROM tarefas WHERE id=@id";
            // Adicionar valores aos parâmetros:
            cmd.Parameters.AddWithValue("@id", this.Id);
            // Executar e capturar a quantidade de linhas inseridas/removidas:
            int linhasAfetadas = cmd.ExecuteNonQuery();

            // Desconectar
            banco.Desconectar();

            // Retornar a quantidade de linhas inseridas
            return linhasAfetadas;
        }
    }
}
