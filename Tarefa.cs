using System;

namespace WinFormsApp1
{
    public class Tarefa
    {
        // Contador estático para gerar IDs únicos
        private static int contadorId = 0;

        // Propriedades da classe
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public DateOnly PrazoFinal { get; private set; }
        public string Status { get; private set; }

        // Construtor
        public Tarefa(string nome, string descricao, DateOnly prazoFinal, string status)
        {
            Id = ++contadorId; // Incrementa o ID único
            Nome = nome;
            Descricao = descricao;
            PrazoFinal = prazoFinal;
            Status = status;
        }

        // Método para editar a tarefa
        public void EditarTarefa(string nome, string descricao, DateOnly prazoFinal, string status)
        {
            Nome = nome;
            Descricao = descricao;
            PrazoFinal = prazoFinal;
            Status = status;
        }

        // Método para exibir as informações da tarefa (opcional, para depuração)
        public override string ToString()
        {
            return $"[{Id}] {Nome} - {Descricao} (Prazo: {PrazoFinal}, Status: {Status})";
        }
    }
}
