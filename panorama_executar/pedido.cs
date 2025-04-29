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
    public partial class pedido : Form
    {
        public pedido()
        {
            InitializeComponent();
        }

        public pedido(string nome, string telefone, string preco, string status, string pagamento)
        {
            txt_nome.Text = nome;
            txt_telefone = telefone;
            txt_preco.Text = preco;
            txt_entrega.Text = preco;
            txt_status.Text = status;
            txt_pagamento.Text = pagamento;
        }
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrar cadastrar = new cadastrar();
            cadastrar.Show();

            this.Hide();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            pedido pedido = new pedido();
            pedido.Show();

            this.Hide();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();

            this.Hide();
        }

        private void pedido_Load(object sender, EventArgs e)
        {
        }

        private void btn_fechar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

   
    }
}
