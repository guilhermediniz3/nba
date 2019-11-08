using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
namespace NBA3
{
    public partial class Usuariocs : Form
    {
        public Usuariocs()
        {
            InitializeComponent();
        }
        


       

            private void Usuariocs_Load(object sender, EventArgs e)
        {

        }

        private void btnbotao_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();


            MySqlConnection conexao = new MySqlConnection(conn);
            try
            {
                conexao.Open();
                
                MySqlCommand comando = new MySqlCommand("select * from usuario", conexao);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read()) { 

                    string usuario = (string)reader[0];
                    MessageBox.Show((String)reader[0]);
                    MessageBox.Show(usuario + "teste sucesso");

                }


            }    
                
            

            catch (MySqlException msqle)
                {
                MessageBox.Show("ERRO DE CONEXAO" + msqle.Message, "erro") ;

            }
            finally
            {
                conexao.Close();

    
            }
        }

        private void butao_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();


            MySqlConnection conexao = new MySqlConnection(conn);
            try
            {
                conexao.Open();
                String nome = "guilhermo";
                String senha = "9292";
                int nivel = 10;
                String email = "teste";

                String query = $"insert into usuario values ('{nome}', {senha}, {nivel}, '{email}')";
                MessageBox.Show(query);
                MySqlCommand comando = new MySqlCommand(query, conexao);
                MySqlDataReader reader = comando.ExecuteReader();
            }
            catch(MySqlException err)
            {
                MessageBox.Show("ERRO DE CONEXAO" + err.Message, "erro"); 
            }
        }
    }
}
