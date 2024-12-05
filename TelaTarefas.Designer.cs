

namespace WinFormsApp1
{
    partial class ToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            NomeTextBox = new TextBox();
            label1 = new Label();
            DescriçãoTextBox = new TextBox();
            label2 = new Label();
            EditarButton = new Button();
            DeletarButton = new Button();
            SalvarButton = new Button();
            ToDoListView = new DataGridView();
            label3 = new Label();
            CampoPrazoFinal = new DateTimePicker();
            label4 = new Label();
            StatusComboBox = new ComboBox();
            tarefaBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ToDoListView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tarefaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BackgroundImage = Properties.Resources._360_F_917621476_leNjR2scxH9ouCRRIR4nI16QyEtqHAVJ;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1118, 94);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._1421804;
            pictureBox1.Location = new Point(62, 15);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(127, 32);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(174, 31);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Lista de tarefas";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // NomeTextBox
            // 
            NomeTextBox.Location = new Point(44, 178);
            NomeTextBox.Margin = new Padding(3, 2, 3, 2);
            NomeTextBox.Name = "NomeTextBox";
            NomeTextBox.Size = new Size(489, 23);
            NomeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 157);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // DescriçãoTextBox
            // 
            DescriçãoTextBox.Location = new Point(44, 238);
            DescriçãoTextBox.Margin = new Padding(3, 2, 3, 2);
            DescriçãoTextBox.Name = "DescriçãoTextBox";
            DescriçãoTextBox.Size = new Size(489, 23);
            DescriçãoTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 217);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "Descrição:";
            // 
            // EditarButton
            // 
            EditarButton.BackColor = Color.FromArgb(192, 255, 255);
            EditarButton.BackgroundImageLayout = ImageLayout.Stretch;
            EditarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditarButton.ForeColor = Color.Navy;
            EditarButton.Image = Properties.Resources.light_blue_2iuzyh711jo9bmgo;
            EditarButton.Location = new Point(218, 408);
            EditarButton.Margin = new Padding(3, 2, 3, 2);
            EditarButton.Name = "EditarButton";
            EditarButton.RightToLeft = RightToLeft.No;
            EditarButton.Size = new Size(141, 60);
            EditarButton.TabIndex = 6;
            EditarButton.Text = "Editar";
            EditarButton.UseVisualStyleBackColor = false;
            EditarButton.Click += EditarButton_Click;
            // 
            // DeletarButton
            // 
            DeletarButton.BackColor = Color.Red;
            DeletarButton.BackgroundImageLayout = ImageLayout.Center;
            DeletarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeletarButton.ForeColor = Color.FromArgb(64, 0, 0);
            DeletarButton.Location = new Point(392, 408);
            DeletarButton.Margin = new Padding(3, 2, 3, 2);
            DeletarButton.Name = "DeletarButton";
            DeletarButton.Size = new Size(141, 60);
            DeletarButton.TabIndex = 7;
            DeletarButton.Text = "Deletar";
            DeletarButton.UseVisualStyleBackColor = false;
            DeletarButton.Click += DeletarButton_Click;
            // 
            // SalvarButton
            // 
            SalvarButton.BackColor = Color.Lime;
            SalvarButton.BackgroundImage = Properties.Resources.cool_green_background_inxfifcr4k5ialt9;
            SalvarButton.BackgroundImageLayout = ImageLayout.Stretch;
            SalvarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalvarButton.ForeColor = Color.Green;
            SalvarButton.ImageAlign = ContentAlignment.BottomCenter;
            SalvarButton.Location = new Point(45, 408);
            SalvarButton.Margin = new Padding(3, 2, 3, 2);
            SalvarButton.Name = "SalvarButton";
            SalvarButton.Size = new Size(141, 60);
            SalvarButton.TabIndex = 8;
            SalvarButton.Text = "Salvar";
            SalvarButton.UseVisualStyleBackColor = false;
            SalvarButton.Click += SalvarButton_Click;
            // 
            // ToDoListView
            // 
            ToDoListView.BackgroundColor = Color.White;
            ToDoListView.BorderStyle = BorderStyle.Fixed3D;
            ToDoListView.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            ToDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ToDoListView.Location = new Point(570, 122);
            ToDoListView.Margin = new Padding(3, 2, 3, 2);
            ToDoListView.Name = "ToDoListView";
            ToDoListView.RowHeadersWidth = 51;
            ToDoListView.Size = new Size(548, 477);
            ToDoListView.TabIndex = 9;
            ToDoListView.CellContentClick += ToDoListView_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 269);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 10;
            label3.Text = "Data:";
            label3.Click += label3_Click;
            // 
            // CampoPrazoFinal
            // 
            CampoPrazoFinal.Location = new Point(44, 290);
            CampoPrazoFinal.Margin = new Padding(3, 2, 3, 2);
            CampoPrazoFinal.Name = "CampoPrazoFinal";
            CampoPrazoFinal.Size = new Size(489, 23);
            CampoPrazoFinal.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 334);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 12;
            label4.Text = "Status:";
            label4.Click += label4_Click;
            // 
            // StatusComboBox
            // 
            StatusComboBox.DataSource = tarefaBindingSource;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(45, 352);
            StatusComboBox.Margin = new Padding(3, 2, 3, 2);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(488, 23);
            StatusComboBox.TabIndex = 13;
            // 
            // tarefaBindingSource
            // 
            tarefaBindingSource.DataSource = typeof(Tarefa);
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.istockphoto_1370858067_612x612;
            ClientSize = new Size(1088, 645);
            Controls.Add(StatusComboBox);
            Controls.Add(label4);
            Controls.Add(CampoPrazoFinal);
            Controls.Add(label3);
            Controls.Add(ToDoListView);
            Controls.Add(SalvarButton);
            Controls.Add(DeletarButton);
            Controls.Add(EditarButton);
            Controls.Add(label2);
            Controls.Add(DescriçãoTextBox);
            Controls.Add(label1);
            Controls.Add(NomeTextBox);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ToDoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Tarefas";
            Load += ListToDo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ToDoListView).EndInit();
            ((System.ComponentModel.ISupportInitialize)tarefaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel1;
        private TextBox NomeTextBox;
        private Label label1;
        private TextBox DescriçãoTextBox;
        private Label label2;
        private Button EditarButton;
        private Button DeletarButton;
        private Button SalvarButton;
        private DataGridView ToDoListView;
        private PictureBox pictureBox1;
        private Label label3;
        private DateTimePicker CampoPrazoFinal;
        private Label label4;
        private ComboBox StatusComboBox;
        private BindingSource tarefaBindingSource;
    }
}
