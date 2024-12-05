using System.Data;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
    // Definindo a classe principal da aplicação
    public partial class ToDoList : Form
    {
        // Atributos da classe
        private bool isEditing = false; // Flag para verificar se estamos editando uma tarefa existente
        private List<Tarefa> listaDeTarefas = new List<Tarefa>(); // Lista de tarefas a ser exibida no DataGridView
        private int currentEditingIndex = -1; // Índice da tarefa que está sendo editada

        // Construtor da classe
        public ToDoList()
        {
            InitializeComponent(); // Inicializa os componentes da interface gráfica

            // Criação de uma lista com os status possíveis das tarefas
            var statusList = new List<string> { "Concluído", "Pendente" };

            // Vinculando a lista ao ComboBox de status
            StatusComboBox.DataSource = statusList;
            StatusComboBox.Enabled = false; // Inicialmente desabilita o ComboBox de status para adição de novas tarefas

            // Define o status padrão do ComboBox como "Pendente"
            if (StatusComboBox.Items.Count > 1)
            {
                StatusComboBox.SelectedIndex = 1;
            }
        }

        // Evento do linkLabel (não utilizado no código)
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        // Evento do label1 (não utilizado no código)
        private void label1_Click(object sender, EventArgs e)
        {
        }

        // Evento para o clique de células no DataGridView (não utilizado no código)
        private void ToDoListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Evento que ocorre quando o formulário é carregado
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
            var bindingList = new BindingSource { DataSource = listaDeTarefas }; // Cria uma fonte de dados para vincular à lista de tarefas
            ToDoListView.DataSource = bindingList; // Vincula a fonte de dados ao DataGridView
        }

        //// Evento do botão "Novo", que limpa os campos e prepara o formulário para adicionar uma nova tarefa
        //private void NovoButton_Click(object sender, EventArgs e)
        //{
        //    NomeTextBox.Text = ""; // Limpa o campo de nome da tarefa
        //    DescriçãoTextBox.Text = ""; // Limpa o campo de descrição da tarefa
        //    isEditing = false; // Marca que não está editando
        //    currentEditingIndex = -1; // Reseta o índice de edição
        //}

        // Evento do botão "Editar", que habilita os campos e carrega os dados da tarefa selecionada para edição
        private void EditarButton_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada no DataGridView
            if (ToDoListView.CurrentRow == null)
            {
                MessageBox.Show("A lista de tarefas está vazia!", "Erro");
                return;
            }

            // Habilita o ComboBox de status para edição
            StatusComboBox.Enabled = true;

            isEditing = true; // Marca como edição
            currentEditingIndex = ToDoListView.CurrentRow.Index; // Salva o índice da tarefa selecionada

            // Carrega os dados da tarefa selecionada nos campos de texto
            var tarefa = listaDeTarefas[currentEditingIndex];
            NomeTextBox.Text = tarefa.Nome;
            DescriçãoTextBox.Text = tarefa.Descricao;
            StatusComboBox.SelectedIndex = tarefa.Status == "Concluído" ? 0 : 1; // Define o status no ComboBox
        }

        // Evento do botão "Deletar", que remove a tarefa selecionada
        private void DeletarButton_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada no DataGridView
            if (ToDoListView.CurrentRow == null)
            {
                MessageBox.Show("A lista de tarefas está vazia!", "Erro");
                return;
            }

            int index = ToDoListView.CurrentRow.Index; // Obtém o índice da tarefa selecionada
            listaDeTarefas.RemoveAt(index); // Remove a tarefa da lista
            AtualizarDataGrid(); // Atualiza o DataGridView

            MessageBox.Show("Tarefa deletada com sucesso!", "Sucesso"); // Exibe mensagem de sucesso
        }

        // Evento do botão "Salvar", que salva ou edita a tarefa com base nos dados inseridos
        private void SalvarButton_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos obrigatórios foram preenchidos e se a data final é menor que a data de hoje
            if (string.IsNullOrWhiteSpace(NomeTextBox.Text) || CampoPrazoFinal.Value == DateTime.MinValue || CampoPrazoFinal.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios e verifique a data final.", "Aviso");
                return;
            }

            // Obtém os dados inseridos nos campos
            string nome = NomeTextBox.Text;
            string descricao = DescriçãoTextBox.Text;
            DateOnly prazoFinal = DateOnly.FromDateTime(CampoPrazoFinal.Value);
            string status = StatusComboBox.SelectedIndex == 0 ? "Concluído" : "Pendente";

            // Se estiver editando uma tarefa existente, atualiza a tarefa
            if (isEditing && currentEditingIndex >= 0)
            {
                listaDeTarefas[currentEditingIndex].EditarTarefa(nome, descricao, prazoFinal, status);
            }
            else
            { 
                listaDeTarefas.Add(new Tarefa(nome, descricao, prazoFinal, status));
            }

            // Limpa os campos de texto após salvar e retorna ao estado inicial as flags e outros campos
            NomeTextBox.Text = "";
            DescriçãoTextBox.Text = "";
            StatusComboBox.Enabled = false;
            isEditing = false;
            currentEditingIndex = -1;
            AtualizarDataGrid(); // Atualiza o DataGridView com os dados mais recentes
        }

        // Eventos de clique para labels (não utilizados no código)
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}
