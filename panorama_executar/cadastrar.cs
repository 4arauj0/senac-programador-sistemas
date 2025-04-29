using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace costura
{
    public partial class cadastrar : Form
    {
        public cadastrar()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // evento vazio
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrar novaTela = new cadastrar();
            novaTela.Show();
            this.Hide();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            pedido novaTela = new pedido();
            novaTela.Show();
            this.Hide();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home novaTela = new home();
            novaTela.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            string telefone = txt_telefone.Text;
            string preco = txt_preco.Text;
            string entrega = txt_entrega.Text;
            string status = txt_status.Text;
            string pagamento = txt_pagamento.Text;

            pedido novaTela = new pedido(nome, telefone, preco, entrega, status, pagamento);
            novaTela.Show();
            this.Hide();
        }
    }

    // Classe "pedido" separada corretamente, dentro do mesmo arquivo (ou você pode mover para pedido.cs)
    public class pedido : Form
    {
        private string nome;
        private string telefone;
        private string preco;
        private string entrega;
        private string status;
        private string pagamento;

        public pedido() { }

        public pedido(string nome, string telefone, string preco, string entrega, string status, string pagamento)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.preco = preco;
            this.entrega = entrega;
            this.status = status;
            this.pagamento = pagamento;

            InitializeComponent();
            // Aqui você pode usar os dados para preencher labels ou campos da tela
        }

        private void InitializeComponent()
        {
            // Montagem básica do formulário, substitua com seu código real de UI
            this.Text = "Pedido";
            this.Width = 400;
            this.Height = 300;
        }
    }
}
