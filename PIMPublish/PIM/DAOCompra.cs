using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    class DAOCompra
    {

        public void adicionar(ProdutoClass produto, Cliente cliente)
        {
            

            String query;
            try
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();

                query = "INSERT INTO compra (nome, cpf, id_produto, dta_compra) VALUES (@nome, @cpf,@id_produto, @dta_compra) ; ";


                conn.Open();


                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("nome", produto.Nome));
                cmd.Parameters.Add(new MySqlParameter("CPF", cliente.CPF));
                cmd.Parameters.Add(new MySqlParameter("id_produto", produto.ID));
                cmd.Parameters.Add(new MySqlParameter("dta_compra",  DateTime.Today));
              

                
                cmd.Prepare();
                cmd.ExecuteNonQuery();


                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }


                MessageBox.Show("Compra adicionada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex.ToString());
            }
        }



        public DataTable PesquisarGeral()
        {


            MySqlConnection conn = new ConnectionFactory().GetConnection();
            conn.Open();
            DataTable tabela = new DataTable();
            String query = "select * from compra;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            MySqlDataAdapter DadosFuncionarios = new MySqlDataAdapter(query, conn);
            conn.Close();
            DadosFuncionarios.Fill(tabela);

            return tabela;

        }
    }
}
