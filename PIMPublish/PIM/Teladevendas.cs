﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class Teladevendas : Form
    {
        public Teladevendas()
        {
            InitializeComponent();
        }
        ProdutoClass produto = new ProdutoClass();



        private int qtd, id;
        private String nome;
        private Decimal valor_unit, subtotal;


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            FinalizarVenda finalizarVenda = new FinalizarVenda();
            finalizarVenda.Show();
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void TbxCodigo_TextChanged(object sender, EventArgs e)
        {
           

            
            id = Convert.ToInt32(TbxCodigo.Text);

        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            Colunas_carrinho();

            Carrinho.Rows.Add(id, nome, qtd, valor_unit);

            decimal x, y;

            foreach (DataGridViewRow row in Carrinho.Rows)
            {
                row.Cells["Preço Conj."].Value = Convert.ToDecimal(row.Cells["Quantidade"].Value) * Convert.ToDecimal(row.Cells["Preço Unit."].Value);
                total.Text = Convert.ToString(Carrinho.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["Preço Conj."].Value)));
                
            }

        }

        private void Colunas_carrinho()
        {    
            Carrinho.ColumnCount = 5;
            Carrinho.Columns[0].Name = "ID";
            Carrinho.Columns[1].Name = "Nome";
            Carrinho.Columns[2].Name = "Quantidade";
            Carrinho.Columns[3].Name = "Preço Unit.";
            Carrinho.Columns[4].Name = "Preço Conj.";
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            DAOProduto daoproduto = new DAOProduto();
            

             GridViewListaProcura.DataSource = daoproduto.Pesquisa_Geral();

                /*switch (Categoria.Text)
                {
                    case "Vestimenta":

                        GridViewListaProcura.DataSource = daoproduto.PesquisaVestPreco(); break;

                    case "Equipamento":

                        GridViewListaProcura.DataSource = daoproduto.PesquisarEquipPreco(); break;        
                }*/

            /*if(TbxCodigo.Text != null)
            {
                GridViewListaProcura.DataSource = daoproduto.PesquisarPorID(id);
            }*/

        }


        private void TbxNomeProduto_TextChanged(object sender, EventArgs e)
        {
            TbxNomeProduto.Text = null;

            nome = TbxNomeProduto.Text;
        }


        private void Tbxtotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Carrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void GridViewListaProcura_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewCell cell = null;


            foreach (DataGridViewCell selectedCell in GridViewListaProcura.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                TbxCodigo.Text = row.Cells["id_produto"].Value.ToString();
                TbxNomeProduto.Text = Convert.ToString(row.Cells["nome1"].Value);
                TbxPrecoUnit.Text = Convert.ToString(row.Cells["Qtd_Estoque"].Value);
            }
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.Carrinho.SelectedRows)
            {
                Carrinho.Rows.RemoveAt(item.Index);
            }

            foreach (DataGridViewRow row in Carrinho.Rows)
            {
                row.Cells["Preço Conj."].Value = Convert.ToDecimal(row.Cells["Quantidade"].Value) * Convert.ToDecimal(row.Cells["Preço Unit."].Value);
                total.Text = Convert.ToString(Carrinho.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["Preço Conj."].Value)));

            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void Teladevendas_Load(object sender, EventArgs e)
        {
            DAOProduto daoproduto = new DAOProduto();

            GridViewListaProcura.AutoGenerateColumns = false;

            GridViewListaProcura.DataSource = daoproduto.Pesquisa_Geral();
            

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TbxPrecoUnit_TextChanged(object sender, EventArgs e)
        {
            TbxPrecoUnit.Text = null;

             valor_unit = Convert.ToDecimal(TbxPrecoUnit.Text);
        }

        private void TbxQtdProduto_TextChanged(object sender, EventArgs e)
        {
            
            qtd = Convert.ToInt32(TbxQtdProduto.Text);
           
        }
    }
}
