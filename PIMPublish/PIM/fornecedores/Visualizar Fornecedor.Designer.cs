﻿namespace PIM.fornecedores
{
    partial class Visualizar_Fornecedor
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
            this.BtnRemover = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DtaGridFornecedor = new System.Windows.Forms.DataGridView();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Tbxcodigopesquisa = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbxnomepesquisa = new System.Windows.Forms.TextBox();
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TbxCNPJpesquisa = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridFornecedor)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRemover
            // 
            this.BtnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemover.BackColor = System.Drawing.Color.Transparent;
            this.BtnRemover.BackgroundImage = global::PIM.Properties.Resources.BtnRemover;
            this.BtnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRemover.FlatAppearance.BorderSize = 0;
            this.BtnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemover.Location = new System.Drawing.Point(751, 506);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(228, 112);
            this.BtnRemover.TabIndex = 20;
            this.BtnRemover.UseVisualStyleBackColor = false;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdicionar.BackgroundImage = global::PIM.Properties.Resources.BtnAdicionar1;
            this.BtnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdicionar.FlatAppearance.BorderSize = 0;
            this.BtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionar.Location = new System.Drawing.Point(751, 236);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(228, 112);
            this.BtnAdicionar.TabIndex = 18;
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::PIM.Properties.Resources.PanelLista;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.DtaGridFornecedor);
            this.panel4.Location = new System.Drawing.Point(26, 236);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 458);
            this.panel4.TabIndex = 17;
            // 
            // DtaGridFornecedor
            // 
            this.DtaGridFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtaGridFornecedor.BackgroundColor = System.Drawing.Color.White;
            this.DtaGridFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtaGridFornecedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DtaGridFornecedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtaGridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtaGridFornecedor.Location = new System.Drawing.Point(14, 17);
            this.DtaGridFornecedor.Name = "DtaGridFornecedor";
            this.DtaGridFornecedor.Size = new System.Drawing.Size(666, 409);
            this.DtaGridFornecedor.TabIndex = 0;
            this.DtaGridFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaGridFornecedor_CellContentClick_1);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.BackgroundImage = global::PIM.Properties.Resources.BtnEditar;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Location = new System.Drawing.Point(751, 370);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(228, 112);
            this.BtnEditar.TabIndex = 19;
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::PIM.Properties.Resources.PanelPesquisarBase12;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.BtnPesquisa);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(28, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(948, 112);
            this.panel3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(164, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Codigo:";
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::PIM.Properties.Resources.TbxCidade;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.Tbxcodigopesquisa);
            this.panel8.Location = new System.Drawing.Point(11, 56);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(145, 44);
            this.panel8.TabIndex = 6;
            // 
            // Tbxcodigopesquisa
            // 
            this.Tbxcodigopesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbxcodigopesquisa.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbxcodigopesquisa.Location = new System.Drawing.Point(9, 10);
            this.Tbxcodigopesquisa.Name = "Tbxcodigopesquisa";
            this.Tbxcodigopesquisa.Size = new System.Drawing.Size(124, 24);
            this.Tbxcodigopesquisa.TabIndex = 1;
            this.Tbxcodigopesquisa.TextChanged += new System.EventHandler(this.Tbxcodigopesquisa_TextChanged);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackgroundImage = global::PIM.Properties.Resources.TbxNome;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.tbxnomepesquisa);
            this.panel7.Location = new System.Drawing.Point(165, 55);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(297, 46);
            this.panel7.TabIndex = 5;
            // 
            // tbxnomepesquisa
            // 
            this.tbxnomepesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxnomepesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxnomepesquisa.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxnomepesquisa.Location = new System.Drawing.Point(6, 11);
            this.tbxnomepesquisa.Name = "tbxnomepesquisa";
            this.tbxnomepesquisa.Size = new System.Drawing.Size(279, 24);
            this.tbxnomepesquisa.TabIndex = 2;
            this.tbxnomepesquisa.TextChanged += new System.EventHandler(this.tbxnomepesquisa_TextChanged);
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPesquisa.BackgroundImage = global::PIM.Properties.Resources.BtnPesquisar;
            this.BtnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPesquisa.FlatAppearance.BorderSize = 0;
            this.BtnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisa.Location = new System.Drawing.Point(694, 14);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(229, 88);
            this.BtnPesquisa.TabIndex = 0;
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackgroundImage = global::PIM.Properties.Resources.TbxCidade;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.TbxCNPJpesquisa);
            this.panel6.Location = new System.Drawing.Point(473, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(211, 48);
            this.panel6.TabIndex = 4;
            // 
            // TbxCNPJpesquisa
            // 
            this.TbxCNPJpesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxCNPJpesquisa.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCNPJpesquisa.Location = new System.Drawing.Point(3, 5);
            this.TbxCNPJpesquisa.Mask = "00.000.000/0000-00";
            this.TbxCNPJpesquisa.Name = "TbxCNPJpesquisa";
            this.TbxCNPJpesquisa.Size = new System.Drawing.Size(202, 33);
            this.TbxCNPJpesquisa.TabIndex = 0;
            this.TbxCNPJpesquisa.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TbxCNPJpesquisa_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(470, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "CNPJ:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::PIM.Properties.Resources.Panel;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 86);
            this.panel1.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::PIM.Properties.Resources.LOGO__1_;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(29, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 113);
            this.panel5.TabIndex = 21;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackgroundImage = global::PIM.Properties.Resources.BtnSair1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Location = new System.Drawing.Point(792, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(176, 62);
            this.btnSair.TabIndex = 1;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Visualizar_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PIM.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Visualizar_Fornecedor";
            this.Text = "Visualizar_Fornecedor";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridFornecedor)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox Tbxcodigopesquisa;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbxnomepesquisa;
        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView DtaGridFornecedor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MaskedTextBox TbxCNPJpesquisa;
    }
}