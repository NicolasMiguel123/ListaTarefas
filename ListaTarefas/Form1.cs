using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtualizarDgvtarefas();
        }

        private void AtualizarDgvtarefas()
        {
            Model.Tarefa tarefa = new Model.Tarefa();
            dgvTafefas.DataSource = tarefa.ListarTudo();
        }

        private void txbNomeTarefas_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Verificar se os campos não estão vazios:
            if (txbNomeTarefas.Text.Length < 3)
            {
                MessageBox.Show("O nome da Tarefa não pode estar vazio!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Instanciar um obj do tipo contato
                Model.Tarefa tarefa = new Model.Tarefa();

                tarefa.Nome_Tarefa = txbNomeTarefas.Text;
                tarefa.Prioridade = int.Parse(txbPrioridade.Text);
                tarefa.Data_Limite = dtpDataLimite.Value;

                if (tarefa.Cadastrar() == 1)
                {
                    MessageBox.Show("Show, Adicionado com sucesso!!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarDgvtarefas();

                    

                    // Limpar os campos textbox:
                  txbPrioridade.Clear();
                  txbNomeTarefas.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar contato!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void dgvTafefas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obter o numero da linha que esta selecionada
            int ls = dgvTafefas.SelectedCells[0].RowIndex;
            // Obter o valor (id) da primeira coluna (0) da linha selecionada (ls)
            int idSelecionado = int.Parse(dgvTafefas.Rows[ls].Cells[0].Value.ToString());
            string nome = dgvTafefas.Rows[ls].Cells[1].Value.ToString();

            // Confirmar exlusão:
            DialogResult r = MessageBox.Show($"Quer realmente deletar {idSelecionado} - {nome}?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                Model.Tarefa tarefa = new Model.Tarefa();
                tarefa.Id = idSelecionado;

                if (tarefa.Apagar() == 1)
                {
                    MessageBox.Show("Tarefa removido!", "SUCESOO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgvtarefas();
                }
            }
        }
    }
}
