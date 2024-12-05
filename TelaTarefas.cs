using System.Data;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
    // Definindo a classe principal da aplica��o
    public partial class ToDoList : Form
    {
        // Atributos da classe
        private bool isEditing = false; // Flag para verificar se estamos editando uma tarefa existente
        private List<Tarefa> listaDeTarefas = new List<Tarefa>(); // Lista de tarefas a ser exibida no DataGridView
        private int currentEditingIndex = -1; // �ndice da tarefa que est� sendo editada

        // Construtor da classe
        public ToDoList()
        {
            InitializeComponent(); // Inicializa os componentes da interface gr�fica

            // Cria��o de uma lista com os status poss�veis das tarefas
            var statusList = new List<string> { "Conclu�do", "Pendente" };

            // Vinculando a lista ao ComboBox de status
            StatusComboBox.DataSource = statusList;
            StatusComboBox.Enabled = false; // Inicialmente desabilita o ComboBox de status para adi��o de novas tarefas

            // Define o status padr�o do ComboBox como "Pendente"
            if (StatusComboBox.Items.Count > 1)
            {
                StatusComboBox.SelectedIndex = 1;
            }
        }

        // Evento do linkLabel (n�o utilizado no c�digo)
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        // Evento do label1 (n�o utilizado no c�digo)
        private void label1_Click(object sender, EventArgs e)
        {
        }

        // Evento para o clique de c�lulas no DataGridView (n�o utilizado no c�digo)
        private void ToDoListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Evento que ocorre quando o formul�rio � carregado
        private void ListToDo_Load(object sender, EventArgs e)
        {
            // Configura o DataGridView para gerar automaticamente as colunas a partir das propriedades da lista de tarefas
            ToDoListView.AutoGenerateColumns = true;
            ToDoListView.Columns.Clear(); // Limpa as colunas existentes
            AtualizarDataGrid(); // Atualiza o DataGridView com as tarefas
        }

        // Atualiza os dados exibidos no DataGridView
        private void AtualizarDataGrid()
        {
            var bindingList = new BindingSource { DataSource = listaDeTarefas }; // Cria uma fonte de dados para vincular � lista de tarefas
            ToDoListView.DataSource = bindingList; // Vincula a fonte de dados ao DataGridView
        }

        //// Evento do bot�o "Novo", que limpa os campos e prepara o formul�rio para adicionar uma nova tarefa
        //private void NovoButton_Click(object sender, EventArgs e)
        //{
        //    NomeTextBox.Text = ""; // Limpa o campo de nome da tarefa
        //    Descri��oTextBox.Text = ""; // Limpa o campo de descri��o da tarefa
        //    isEditing = false; // Marca que n�o est� editando
        //    currentEditingIndex = -1; // Reseta o �ndice de edi��o
        //}

        // Evento do bot�o "Editar", que habilita os campos e carrega os dados da tarefa selecionada para edi��o
        private void EditarButton_Click(object sender, EventArgs e)
        {
            // Verifica se h� uma linha selecionada no DataGridView
            if (ToDoListView.CurrentRow == null)
            {
                MessageBox.Show("A lista de tarefas est� vazia!", "Erro");
                return;
            }

            // Habilita o ComboBox de status para edi��o
            StatusComboBox.Enabled = true;

            isEditing = true; // Marca como edi��o
            currentEditingIndex = ToDoListView.CurrentRow.Index; // Salva o �ndice da tarefa selecionada

            // Carrega os dados da tarefa selecionada nos campos de texto
            var tarefa = listaDeTarefas[currentEditingIndex];
            NomeTextBox.Text = tarefa.Nome;
            Descri��oTextBox.Text = tarefa.Descricao;
            StatusComboBox.SelectedIndex = tarefa.Status == "Conclu�do" ? 0 : 1; // Define o status no ComboBox
        }

        // Evento do bot�o "Deletar", que remove a tarefa selecionada
        private void DeletarButton_Click(object sender, EventArgs e)
        {
            // Verifica se h� uma linha selecionada no DataGridView
            if (ToDoListView.CurrentRow == null)
            {
                MessageBox.Show("A lista de tarefas est� vazia!", "Erro");
                return;
            }

            int index = ToDoListView.CurrentRow.Index; // Obt�m o �ndice da tarefa selecionada
            listaDeTarefas.RemoveAt(index); // Remove a tarefa da lista
            AtualizarDataGrid(); // Atualiza o DataGridView

            MessageBox.Show("Tarefa deletada com sucesso!", "Sucesso"); // Exibe mensagem de sucesso
        }

        // Evento do bot�o "Salvar", que salva ou edita a tarefa com base nos dados inseridos
        private void SalvarButton_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos obrigat�rios foram preenchidos e se a data final � menor que a data de hoje
            if (string.IsNullOrWhiteSpace(NomeTextBox.Text) || CampoPrazoFinal.Value == DateTime.MinValue || CampoPrazoFinal.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Preencha todos os campos obrigat�rios e verifique a data final.", "Aviso");
                return;
            }

            // Obt�m os dados inseridos nos campos
            string nome = NomeTextBox.Text;
            string descricao = Descri��oTextBox.Text;
            DateOnly prazoFinal = DateOnly.FromDateTime(CampoPrazoFinal.Value);
            string status = StatusComboBox.SelectedIndex == 0 ? "Conclu�do" : "Pendente";

            // Se estiver editando uma tarefa existente, atualiza a tarefa
            if (isEditing && currentEditingIndex >= 0)
            {
                listaDeTarefas[currentEditingIndex].EditarTarefa(nome, descricao, prazoFinal, status);
            }
            else
            { 
                listaDeTarefas.Add(new Tarefa(nome, descricao, prazoFinal, status));
            }

            // Limpa os campos de texto ap�s salvar e retorna ao estado inicial as flags e outros campos
            NomeTextBox.Text = "";
            Descri��oTextBox.Text = "";
            StatusComboBox.Enabled = false;
            isEditing = false;
            currentEditingIndex = -1;
            AtualizarDataGrid(); // Atualiza o DataGridView com os dados mais recentes
        }

        // Eventos de clique para labels (n�o utilizados no c�digo)
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}
