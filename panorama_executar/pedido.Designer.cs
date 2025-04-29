namespace costura
{
    partial class pedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pedido));
            menuStrip2 = new MenuStrip();
            toolStripMenuItem7 = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            historicoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            txt_nome = new TextBox();
            txt_preco = new TextBox();
            txt_entrega = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_pagamento = new TextBox();
            txt_status = new TextBox();
            txt_telefone = new TextBox();
            lbl_pedido = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.IndianRed;
            menuStrip2.BackgroundImage = (Image)resources.GetObject("menuStrip2.BackgroundImage");
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem7, toolStripMenuItem11 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(808, 24);
            menuStrip2.TabIndex = 23;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, historicoToolStripMenuItem, toolStripMenuItem10 });
            toolStripMenuItem7.Image = (Image)resources.GetObject("toolStripMenuItem7.Image");
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(38, 20);
            toolStripMenuItem7.Text = " ";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Image = (Image)resources.GetObject("cadastrarToolStripMenuItem.Image");
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(124, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // historicoToolStripMenuItem
            // 
            historicoToolStripMenuItem.Image = (Image)resources.GetObject("historicoToolStripMenuItem.Image");
            historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            historicoToolStripMenuItem.Size = new Size(124, 22);
            historicoToolStripMenuItem.Text = "home";
            historicoToolStripMenuItem.Click += historicoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Image = (Image)resources.GetObject("toolStripMenuItem10.Image");
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(124, 22);
            toolStripMenuItem10.Text = "Pedido";
            toolStripMenuItem10.Click += toolStripMenuItem10_Click;
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, cadastrarToolStripMenuItem1 });
            toolStripMenuItem11.Image = (Image)resources.GetObject("toolStripMenuItem11.Image");
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(38, 20);
            toolStripMenuItem11.Text = " ";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Image = (Image)resources.GetObject("loginToolStripMenuItem.Image");
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(124, 22);
            loginToolStripMenuItem.Text = "Login";
            // 
            // cadastrarToolStripMenuItem1
            // 
            cadastrarToolStripMenuItem1.Image = (Image)resources.GetObject("cadastrarToolStripMenuItem1.Image");
            cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            cadastrarToolStripMenuItem1.Size = new Size(124, 22);
            cadastrarToolStripMenuItem1.Text = "Cadastrar";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(798, 459);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(txt_nome);
            groupBox1.Controls.Add(txt_preco);
            groupBox1.Controls.Add(txt_entrega);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_pagamento);
            groupBox1.Controls.Add(txt_status);
            groupBox1.Controls.Add(txt_telefone);
            groupBox1.Location = new Point(275, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 319);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(6, 34);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(210, 23);
            txt_nome.TabIndex = 20;
            // 
            // txt_preco
            // 
            txt_preco.Location = new Point(67, 134);
            txt_preco.Name = "txt_preco";
            txt_preco.Size = new Size(100, 23);
            txt_preco.TabIndex = 19;
            // 
            // txt_entrega
            // 
            txt_entrega.Location = new Point(61, 184);
            txt_entrega.Name = "txt_entrega";
            txt_entrega.Size = new Size(100, 23);
            txt_entrega.TabIndex = 18;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(87, 10);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(53, 21);
            label1.TabIndex = 16;
            label1.Text = "Nome";
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(91, 110);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(49, 21);
            label2.TabIndex = 15;
            label2.Text = "Preço";
            label2.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(85, 160);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(63, 21);
            label3.TabIndex = 17;
            label3.Text = "entrega";
            label3.UseMnemonic = false;
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(62, 264);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(89, 21);
            label4.TabIndex = 10;
            label4.Text = "pagamento";
            label4.UseMnemonic = false;
            // 
            // label5
            // 
            label5.AccessibleRole = AccessibleRole.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(80, 212);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(51, 21);
            label5.TabIndex = 9;
            label5.Text = "status";
            label5.UseMnemonic = false;
            // 
            // label6
            // 
            label6.AccessibleRole = AccessibleRole.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(85, 60);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(66, 21);
            label6.TabIndex = 8;
            label6.Text = "telefone";
            label6.UseMnemonic = false;
            // 
            // txt_pagamento
            // 
            txt_pagamento.Location = new Point(62, 288);
            txt_pagamento.Name = "txt_pagamento";
            txt_pagamento.Size = new Size(100, 23);
            txt_pagamento.TabIndex = 2;
            // 
            // txt_status
            // 
            txt_status.Location = new Point(62, 236);
            txt_status.Name = "txt_status";
            txt_status.Size = new Size(100, 23);
            txt_status.TabIndex = 1;
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(63, 84);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(100, 23);
            txt_telefone.TabIndex = 0;
            // 
            // lbl_pedido
            // 
            lbl_pedido.AccessibleRole = AccessibleRole.None;
            lbl_pedido.AutoSize = true;
            lbl_pedido.BackColor = Color.Transparent;
            lbl_pedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_pedido.ForeColor = SystemColors.ControlLightLight;
            lbl_pedido.Image = (Image)resources.GetObject("lbl_pedido.Image");
            lbl_pedido.Location = new Point(345, 16);
            lbl_pedido.Name = "lbl_pedido";
            lbl_pedido.RightToLeft = RightToLeft.No;
            lbl_pedido.Size = new Size(57, 21);
            lbl_pedido.TabIndex = 28;
            lbl_pedido.Text = "Pedido";
            lbl_pedido.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(808, 21);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(697, 43);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 21;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lbl_pedido);
            Controls.Add(menuStrip2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "pedido";
            Text = "pedido";
            Load += pedido_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem historicoToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private TextBox txt_nome;
        private TextBox txt_preco;
        private TextBox txt_entrega;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_pagamento;
        private TextBox txt_status;
        private TextBox txt_telefone;
        private Label lbl_pedido;
        private PictureBox pictureBox1;
        private Button button1;
    }
}